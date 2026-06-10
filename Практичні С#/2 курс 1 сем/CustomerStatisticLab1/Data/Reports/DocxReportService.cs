using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using DW = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;

namespace Domain.Reports
{
    public class DocxReportService
    {

        public DocxReportService()
        {

        }

        public void GenerateReport(List<Customer> customers, string outputPath, List<string> chartPaths = null)
        {
            using (var wordDoc = WordprocessingDocument.Create(outputPath, WordprocessingDocumentType.Document))
            {
                var mainPart = wordDoc.AddMainDocumentPart();
                mainPart.Document = new Document();
                var body = mainPart.Document.AppendChild(new Body());

                AddTitlePage(body);
                AddPageBreak(body);
                AddMetricsTable(body, customers);

                if (chartPaths != null && chartPaths.Count > 0)
                {
                    AddPageBreak(body);
                    AddParagraph(body, "ГРАФІКИ ТА ДІАГРАМИ", 18, true, JustificationValues.Center);
                    AddEmptyParagraph(body);

                    foreach (var chartPath in chartPaths)
                    {
                        if (File.Exists(chartPath))
                        {
                            AddImage(body, mainPart, chartPath);
                            AddEmptyParagraph(body);
                        }
                    }
                }

                mainPart.Document.Save();
            }
        }

        private void AddTitlePage(Body body)
        {
            AddParagraph(body, "ЗВІТ З АНАЛІЗУ ДАНИХ", 28, true, JustificationValues.Center);
            AddEmptyParagraph(body);
            AddEmptyParagraph(body);

            AddParagraph(body, $"Виконав: Мичка Богдан", 12, false);
            AddParagraph(body, $"Варіант: 12", 12, false);
            AddEmptyParagraph(body);

            AddParagraph(body, "Опис датасету: датасет описує дані про користувачів компанії яка займається " +
                "проведенням телефонних та інтернет ліній і включає в себе інформацію про користувачів, їхні особисті дані" +
                "та інформацію про їхні тарифи.", 12, true);
            AddEmptyParagraph(body);

            AddParagraph(body, $"Дата: {System.DateTime.Now:dd.MM.yyyy}", 11, false);
        }

        private void AddMetricsTable(Body body, List<Customer> customers)
        {
            var metrics = CustomerMetrics.Calculate(customers);

            AddParagraph(body, "КЛЮЧОВІ МЕТРИКИ", 16, true, JustificationValues.Center);
            AddEmptyParagraph(body);

            var table = CreateTable();
            AddTableRow(table, "Метрика", "Значення", true);
            AddTableRow(table, "Загальна кількість клієнтів", metrics.TotalCustomers.ToString());
            AddTableRow(table, "Churn Rate (%)", metrics.ChurnRate.ToString("0.00"));
            AddTableRow(table, "Відсоток пенсіонерів (%)", metrics.SeniorCitizenPercentage.ToString("0.00"));
            AddTableRow(table, "Середній щомісячний платіж", metrics.AverageMonthlyCharges.ToString("0.00"));
            body.AppendChild(table);

            AddEmptyParagraph(body);
            AddParagraph(body, "ПО ТИПУ КОНТРАКТУ", 14, true);
            AddEmptyParagraph(body);

            var contractTable = CreateTable();
            AddTableRow(contractTable, "Тип контракту", "Кількість", "Сер. платіж", true);

            foreach (var type in metrics.CustomersByContractType.Keys)
            {
                AddTableRow(contractTable, type,
                    metrics.CustomersByContractType[type].ToString(),
                    metrics.AverageMonthlyChargesByContract[type].ToString("0.00"));
            }

            body.AppendChild(contractTable);
        }

        private Table CreateTable()
        {
            var table = new Table();
            var borders = new TableBorders(
                new TopBorder() { Val = BorderValues.Single, Size = 4 },
                new BottomBorder() { Val = BorderValues.Single, Size = 4 },
                new LeftBorder() { Val = BorderValues.Single, Size = 4 },
                new RightBorder() { Val = BorderValues.Single, Size = 4 },
                new InsideHorizontalBorder() { Val = BorderValues.Single, Size = 4 },
                new InsideVerticalBorder() { Val = BorderValues.Single, Size = 4 }
            );

            table.AppendChild(new TableProperties(borders));
            return table;
        }

        private void AddTableRow(Table table, string col1, string col2, bool isHeader = false)
        {
            var row = new TableRow();
            row.Append(CreateCell(col1, isHeader));
            row.Append(CreateCell(col2, isHeader));
            table.AppendChild(row);
        }

        private void AddTableRow(Table table, string col1, string col2, string col3, bool isHeader = false)
        {
            var row = new TableRow();
            row.Append(CreateCell(col1, isHeader));
            row.Append(CreateCell(col2, isHeader));
            row.Append(CreateCell(col3, isHeader));
            table.AppendChild(row);
        }

        private TableCell CreateCell(string text, bool isHeader)
        {
            var cell = new TableCell();
            var para = new Paragraph();
            var run = new Run(new Text(text));

            if (isHeader)
            {
                run.RunProperties = new RunProperties(new Bold());
            }

            para.Append(run);
            cell.Append(para);
            return cell;
        }

        private void AddImage(Body body, MainDocumentPart mainPart, string imagePath)
        {
            var imagePart = mainPart.AddImagePart(ImagePartType.Png);

            using (var stream = new FileStream(imagePath, FileMode.Open))
            {
                imagePart.FeedData(stream);
            }

            var inline = new DW.Inline
            {
                Extent = new DW.Extent { Cx = 5486400L, Cy = 3200400L },
                DocProperties = new DW.DocProperties { Id = 1U, Name = "Chart" },
                Graphic = new A.Graphic(
                    new A.GraphicData(
                        new PIC.Picture(
                            new PIC.NonVisualPictureProperties(
                                new PIC.NonVisualDrawingProperties { Id = 0U, Name = "chart.png" },
                                new PIC.NonVisualPictureDrawingProperties()),
                            new PIC.BlipFill(
                                new A.Blip { Embed = mainPart.GetIdOfPart(imagePart) },
                                new A.Stretch(new A.FillRectangle())),
                            new PIC.ShapeProperties(
                                new A.Transform2D(
                                    new A.Offset { X = 0L, Y = 0L },
                                    new A.Extents { Cx = 5486400L, Cy = 3200400L }),
                                new A.PresetGeometry(new A.AdjustValueList()) { Preset = A.ShapeTypeValues.Rectangle })))
                )
            };

            body.AppendChild(new Paragraph(new Run(new Drawing(inline))));
        }

        private void AddParagraph(Body body, string text, int fontSize, bool isBold, JustificationValues? align = null)
        {
            var para = new Paragraph();
            var run = new Run();
            var props = new RunProperties(new FontSize { Val = (fontSize * 2).ToString() });

            if (isBold) props.Append(new Bold());
            if (align.HasValue) para.ParagraphProperties = new ParagraphProperties(new Justification { Val = align.Value });

            run.Append(props);
            run.Append(new Text(text));
            para.Append(run);
            body.Append(para);
        }

        private void AddEmptyParagraph(Body body)
        {
            body.Append(new Paragraph());
        }

        private void AddPageBreak(Body body)
        {
            body.Append(new Paragraph(new Run(new Break { Type = BreakValues.Page })));
        }
    }
}
