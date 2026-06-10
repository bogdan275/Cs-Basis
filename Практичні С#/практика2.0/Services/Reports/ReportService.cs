using ClosedXML.Excel;
using Data.Models;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Services;
using Services.Services;
using System;
using System.IO;
using System.Linq;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Document = DocumentFormat.OpenXml.Wordprocessing.Document;
using Justification = DocumentFormat.OpenXml.Wordprocessing.Justification;
using Paragraph = DocumentFormat.OpenXml.Wordprocessing.Paragraph;
using Run = DocumentFormat.OpenXml.Wordprocessing.Run;
using Table = DocumentFormat.OpenXml.Wordprocessing.Table;

namespace Services.Reports
{
    public class ReportService
    {
        private readonly IncidentService _incidentService;
        private readonly ServiceService _serviceService;
        private readonly EmployeeService _employeeService;

        public ReportService(IncidentService incidentService,
            ServiceService serviceService,
            EmployeeService employeeService)
        {
            _incidentService = incidentService;
            _serviceService = serviceService;
            _employeeService = employeeService;
        }

        public string GetSystemSummaryText()
        {
            var services = _serviceService.GetAllServices().ToList();
            var incidents = _incidentService.GetAllIncidents().ToList();
            var employees = _employeeService.GetAllEmployees().ToList();

            int totalIncidents = incidents.Count;
            int resolvedIncidents = incidents.Count(i => i.Status == "Closed" || i.Status == "Resolved");
            int criticalServices = services.Count(s => s.Criticality == "Critical");

            var topEmployee = incidents
                .Where(i => (i.Status == "Closed" || i.Status == "Resolved") && i.AssignedToEmployee != null)
                .GroupBy(i => i.AssignedToEmployee.FullName)
                .OrderByDescending(g => g.Count())
                .Select(g => new { Name = g.Key, Count = g.Count() })
                .FirstOrDefault();

            var sb = new System.Text.StringBuilder();
            sb.AppendLine("============================================");
            sb.AppendLine("       ЗВІТ СИСТЕМИ МОНІТОРИНГУ             ");
            sb.AppendLine("============================================");
            sb.AppendLine($"Дата формування: {DateTime.Now:F}");
            sb.AppendLine();

            sb.AppendLine("--- ЗАГАЛЬНА СТАТИСТИКА ---");
            sb.AppendLine($"Усього сервісів: {services.Count}");
            sb.AppendLine($"Критичних сервісів: {criticalServices}");
            sb.AppendLine($"Усього інцидентів: {totalIncidents}");
            sb.AppendLine($"Вирішено проблем: {resolvedIncidents}");

            if (topEmployee != null)
            {
                sb.AppendLine($"Найкращий спеціаліст: {topEmployee.Name} ({topEmployee.Count} вир.)");
            }

            sb.AppendLine();
            sb.AppendLine("--- ДЕТАЛЬНА ІСТОРІЯ ІНЦИДЕНТІВ ---");
            sb.AppendLine(string.Format("{0,-12} | {1,-20} | {2,-15}", "Дата", "Сервіс", "Статус"));
            sb.AppendLine(new string('-', 55));


            foreach (var inc in incidents.Take(15))
            {
                string serviceName = inc.Service?.ServiceName ?? "N/A";
                if (serviceName.Length > 18) serviceName = serviceName.Substring(0, 15) + "...";

                sb.AppendLine(string.Format("{0,-12} | {1,-20} | {2,-15}",
                    inc.DetectedAt.ToString("dd.MM.yyyy"),
                    serviceName,
                    inc.Status));
            }

            if (incidents.Count > 15)
            {
                sb.AppendLine($"... та ще {incidents.Count - 15} записів буде додано у файл.");
            }

            return sb.ToString();
        }

        public void ExportSystemReportToDocx(string filePath)
        {
            var services = _serviceService.GetAllServices().ToList();
            var incidents = _incidentService.GetAllIncidents().ToList();

            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                Paragraph titlePara = body.AppendChild(new Paragraph());
                titlePara.AppendChild(new ParagraphProperties(new Justification { Val = JustificationValues.Center }));
                Run titleRun = titlePara.AppendChild(new Run());
                titleRun.AppendChild(new RunProperties(new Bold(), new FontSize { Val = "36" }));
                titleRun.AppendChild(new Text("ЗВІТ СИСТЕМИ МОНІТОРИНГУ"));

                body.AppendChild(new Paragraph(new Run(new Text($"Дата формування: {DateTime.Now:f}"))
                {
                    RunProperties = new RunProperties(new FontSize { Val = "20" })
                }));
                body.AppendChild(new Paragraph(new Run(new Break())));

                // 2. ТАБЛИЦЯ ІНЦИДЕНТІВ
                body.AppendChild(new Paragraph(new Run(new RunProperties(new Bold(), new FontSize { Val = "28" }), new Text("Детальна історія інцидентів"))));

                Table table = new Table();

                // --- ВАЖЛИВО: Налаштування ширини таблиці (100% сторінки) ---
                TableProperties tblProp = new TableProperties(
                    new TableWidth { Width = "5000", Type = TableWidthUnitValues.Pct }, // 5000 = 100% у форматі Pct
                    new TableBorders(
                        new TopBorder { Val = BorderValues.Single, Size = 4 },
                        new BottomBorder { Val = BorderValues.Single, Size = 4 },
                        new LeftBorder { Val = BorderValues.Single, Size = 4 },
                        new RightBorder { Val = BorderValues.Single, Size = 4 },
                        new InsideHorizontalBorder { Val = BorderValues.Single, Size = 4 },
                        new InsideVerticalBorder { Val = BorderValues.Single, Size = 4 }
                    )
                );
                table.AppendChild(tblProp);

                // Додаємо визначення колонок (Grid), щоб Word розумів пропорції
                TableGrid tg = new TableGrid(
                    new GridColumn { Width = "1500" }, // Дата
                    new GridColumn { Width = "2500" }, // Сервіс
                    new GridColumn { Width = "4000" }, // Проблема
                    new GridColumn { Width = "2000" }  // Статус
                );
                table.AppendChild(tg);

                TableRow headerRow = new TableRow();
                string[] headers = { "Дата", "Сервіс", "Проблема", "Статус" };
                foreach (var head in headers)
                {
                    TableCell cell = new TableCell(new Paragraph(new Run(new RunProperties(new Bold()), new Text(head))));
                    headerRow.Append(cell);
                }
                table.Append(headerRow);

                // Дані таблиці
                foreach (var inc in incidents)
                {
                    TableRow row = new TableRow();

                    row.Append(CreateTableCell(inc.DetectedAt.ToString("dd.MM.yyyy")));
                    row.Append(CreateTableCell(inc.Service?.ServiceName ?? "-"));
                    row.Append(CreateTableCell(inc.Title ?? "-"));
                    row.Append(CreateTableCell(inc.Status ?? "-"));

                    table.Append(row);
                }

                body.Append(table);
                mainPart.Document.Save();
            }
        }

        private TableCell CreateTableCell(string text)
        {
            TableCell cell = new TableCell();
            cell.Append(new TableCellProperties(new TableCellWidth { Type = TableWidthUnitValues.Auto }));
            Paragraph p = cell.AppendChild(new Paragraph(new Run(new Text(text))));
            return cell;
        }

        public void ExportSystemReportToExcel(string filePath)
        {
            var services = _serviceService.GetAllServices().ToList();
            var incidents = _incidentService.GetAllIncidents().ToList();

            using (var workbook = new XLWorkbook())
            {
                var wsStat = workbook.Worksheets.Add("Загальна статистика");

                wsStat.Cell(1, 1).Value = "Параметр";
                wsStat.Cell(1, 2).Value = "Значення";
                wsStat.Row(1).Style.Font.Bold = true;

                wsStat.Cell(2, 1).Value = "Дата звіту";
                wsStat.Cell(2, 2).Value = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                wsStat.Cell(3, 1).Value = "Усього сервісів";
                wsStat.Cell(3, 2).Value = services.Count;

                wsStat.Cell(4, 1).Value = "Критичних сервісів";
                wsStat.Cell(4, 2).Value = services.Count(s => s.Criticality == "Critical");

                wsStat.Cell(5, 1).Value = "Усього інцидентів";
                wsStat.Cell(5, 2).Value = incidents.Count;

                wsStat.Cell(6, 1).Value = "Вирішено інцидентів";
                wsStat.Cell(6, 2).Value = incidents.Count(i => i.Status == "Closed" || i.Status == "Resolved");

                var topEmployee = incidents
                    .Where(i => (i.Status == "Closed" || i.Status == "Resolved") && i.AssignedToEmployee != null)
                    .GroupBy(i => i.AssignedToEmployee.FullName)
                    .OrderByDescending(g => g.Count())
                    .Select(g => new { Name = g.Key, Count = g.Count() })
                    .FirstOrDefault();

                if (topEmployee != null)
                {
                    wsStat.Cell(8, 1).Value = "Найкращий спеціаліст";
                    wsStat.Cell(8, 2).Value = $"{topEmployee.Name} ({topEmployee.Count} вир.)";
                }

                wsStat.Columns().AdjustToContents();

                var wsHistory = workbook.Worksheets.Add("Історія інцидентів");
                wsHistory.Cell(1, 1).Value = "Дата виявлення";
                wsHistory.Cell(1, 2).Value = "Сервіс";
                wsHistory.Cell(1, 3).Value = "Заголовок";
                wsHistory.Cell(1, 4).Value = "Статус";
                wsHistory.Cell(1, 5).Value = "Пріоритет";
                wsHistory.Row(1).Style.Font.Bold = true;

                for (int i = 0; i < incidents.Count; i++)
                {
                    wsHistory.Cell(i + 2, 1).Value = incidents[i].DetectedAt;
                    wsHistory.Cell(i + 2, 2).Value = incidents[i].Service?.ServiceName;
                    wsHistory.Cell(i + 2, 3).Value = incidents[i].Title;
                    wsHistory.Cell(i + 2, 4).Value = incidents[i].Status;
                    wsHistory.Cell(i + 2, 5).Value = incidents[i].Priority;
                }

                wsHistory.Columns().AdjustToContents();
                workbook.SaveAs(filePath);
            }
        }
    }
}