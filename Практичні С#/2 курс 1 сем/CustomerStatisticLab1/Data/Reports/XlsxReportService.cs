using System;
using System.Collections.Generic;
using System.Text;
using ClosedXML.Excel;
using Core.Entities;

namespace Domain.Reports
{
    public class XlsxReportService
    {
        /// <summary>
        /// Створити XLSX звіт з даними та метриками
        /// </summary>
        public void GenerateReport(List<Customer> customers, string outputPath)
        {
            using (var workbook = new XLWorkbook())
            {
                // Аркуш 1: Всі дані
                CreateDataSheet(workbook, customers);

                // Аркуш 2: Підсумкові таблиці
                CreateSummarySheet(workbook, customers);

                workbook.SaveAs(outputPath);
            }
        }

        /// <summary>
        /// Аркуш з усіма даними клієнтів
        /// </summary>
        private void CreateDataSheet(XLWorkbook workbook, List<Customer> customers)
        {
            var worksheet = workbook.Worksheets.Add("All Customers");

            // Заголовки
            worksheet.Cell(1, 1).Value = "Customer ID";
            worksheet.Cell(1, 2).Value = "Gender";
            worksheet.Cell(1, 3).Value = "Senior Citizen";
            worksheet.Cell(1, 4).Value = "Partner";
            worksheet.Cell(1, 5).Value = "Dependents";
            worksheet.Cell(1, 6).Value = "Tenure (Months)";
            worksheet.Cell(1, 7).Value = "Phone Service";
            worksheet.Cell(1, 8).Value = "Internet Service";
            worksheet.Cell(1, 9).Value = "Contract Type";
            worksheet.Cell(1, 10).Value = "Payment Method";
            worksheet.Cell(1, 11).Value = "Monthly Charges";
            worksheet.Cell(1, 12).Value = "Total Charges";
            worksheet.Cell(1, 13).Value = "Churned";

            // Форматування заголовків
            var headerRange = worksheet.Range(1, 1, 1, 13);
            headerRange.Style.Font.Bold = true;
            headerRange.Style.Fill.BackgroundColor = XLColor.LightBlue;
            headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            // Дані
            int row = 2;
            foreach (var customer in customers)
            {
                worksheet.Cell(row, 1).Value = customer.CustomerID;
                worksheet.Cell(row, 2).Value = customer.Gender;
                worksheet.Cell(row, 3).Value = customer.IsSeniorCitizen ? "Yes" : "No";
                worksheet.Cell(row, 4).Value = customer.HasPartner ? "Yes" : "No";
                worksheet.Cell(row, 5).Value = customer.HasDependents ? "Yes" : "No";
                worksheet.Cell(row, 6).Value = customer.TenureMonths;
                worksheet.Cell(row, 7).Value = customer.Services.HasPhoneService ? "Yes" : "No";
                worksheet.Cell(row, 8).Value = customer.Services.InternetService;
                worksheet.Cell(row, 9).Value = customer.Contract.ContractType;
                worksheet.Cell(row, 10).Value = customer.Contract.PaymentMethod;
                worksheet.Cell(row, 11).Value = customer.MonthlyCharges;
                worksheet.Cell(row, 12).Value = customer.TotalCharges;
                worksheet.Cell(row, 13).Value = customer.HasChurned ? "Yes" : "No";

                row++;
            }

            // Автоширина
            worksheet.Columns().AdjustToContents();
        }

        /// <summary>
        /// Аркуш з підсумковими таблицями
        /// </summary>
        private void CreateSummarySheet(XLWorkbook workbook, List<Customer> customers)
        {
            var worksheet = workbook.Worksheets.Add("Summary Metrics");
            var metrics = CustomerMetrics.Calculate(customers);

            int currentRow = 1;

            worksheet.Cell(currentRow, 1).Value = "GENERAL METRICS";
            worksheet.Cell(currentRow, 1).Style.Font.FontSize = 14;
            currentRow += 2;

            worksheet.Cell(currentRow, 1).Value = "Total Customers";
            worksheet.Cell(currentRow, 2).Value = metrics.TotalCustomers;
            currentRow++;

            worksheet.Cell(currentRow, 1).Value = "Churn Rate (%)";
            worksheet.Cell(currentRow, 2).Value = metrics.ChurnRate;
            worksheet.Cell(currentRow, 2).Style.NumberFormat.Format = "0.00";
            currentRow++;

            worksheet.Cell(currentRow, 1).Value = "Senior Citizen Percentage (%)";
            worksheet.Cell(currentRow, 2).Value = metrics.SeniorCitizenPercentage;
            worksheet.Cell(currentRow, 2).Style.NumberFormat.Format = "0.00";
            currentRow++;

            worksheet.Cell(currentRow, 1).Value = "Average Tenure (Months)";
            worksheet.Cell(currentRow, 2).Value = metrics.AverageTenure;
            worksheet.Cell(currentRow, 2).Style.NumberFormat.Format = "0.00";
            currentRow++;

            worksheet.Cell(currentRow, 1).Value = "Average Monthly Charges";
            worksheet.Cell(currentRow, 2).Value = metrics.AverageMonthlyCharges;
            worksheet.Cell(currentRow, 2).Style.NumberFormat.Format = "0.00";
            currentRow++;

            worksheet.Cell(currentRow, 1).Value = "Average Total Charges";
            worksheet.Cell(currentRow, 2).Value = metrics.AverageTotalCharges;
            worksheet.Cell(currentRow, 2).Style.NumberFormat.Format = "0.00";
            currentRow += 3;

            worksheet.Cell(currentRow, 1).Value = "SENIOR CITIZENS STATISTICS";
            worksheet.Cell(currentRow, 1).Style.Font.FontSize = 14;
            currentRow += 2;

            worksheet.Cell(currentRow, 1).Value = "Total Senior Citizens";
            worksheet.Cell(currentRow, 2).Value = metrics.SeniorCitizensCount;
            currentRow++;

            worksheet.Cell(currentRow, 1).Value = "Senior Citizens with Dependents";
            worksheet.Cell(currentRow, 2).Value = metrics.SeniorCitizensWithDependents;
            currentRow++;

            worksheet.Cell(currentRow, 1).Value = "Senior Citizens with Partner";
            worksheet.Cell(currentRow, 2).Value = metrics.SeniorCitizensWithPartner;
            currentRow += 3;

            worksheet.Cell(currentRow, 1).Value = "ADDITIONAL STATISTICS";
            worksheet.Cell(currentRow, 1).Style.Font.FontSize = 14;
            currentRow += 2;

            worksheet.Cell(currentRow, 1).Value = "Customers with Partner";
            worksheet.Cell(currentRow, 2).Value = metrics.CustomersWithPartner;
            currentRow++;

            worksheet.Cell(currentRow, 1).Value = "Customers with Dependents";
            worksheet.Cell(currentRow, 2).Value = metrics.CustomersWithDependents;
            currentRow++;

            worksheet.Cell(currentRow, 1).Value = "Customers with Phone Service";
            worksheet.Cell(currentRow, 2).Value = metrics.CustomersWithPhoneService;
            currentRow += 3;

            worksheet.Cell(currentRow, 1).Value = "METRICS BY CONTRACT TYPE";
            worksheet.Cell(currentRow, 1).Style.Font.FontSize = 14;
            currentRow += 2;

            worksheet.Cell(currentRow, 1).Value = "Contract Type";
            worksheet.Cell(currentRow, 2).Value = "Customer Count";
            worksheet.Cell(currentRow, 3).Value = "Avg Monthly Charges";
            worksheet.Cell(currentRow, 4).Value = "Churn Rate (%)";

            var headerRange = worksheet.Range(currentRow, 1, currentRow, 4);
            headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
            currentRow++;

            foreach (var contractType in metrics.CustomersByContractType.Keys)
            {
                worksheet.Cell(currentRow, 1).Value = contractType;
                worksheet.Cell(currentRow, 2).Value = metrics.CustomersByContractType[contractType];
                worksheet.Cell(currentRow, 3).Value = metrics.AverageMonthlyChargesByContract[contractType];
                worksheet.Cell(currentRow, 3).Style.NumberFormat.Format = "0.00";
                worksheet.Cell(currentRow, 4).Value = metrics.ChurnRateByContractType[contractType];
                worksheet.Cell(currentRow, 4).Style.NumberFormat.Format = "0.00";
                currentRow++;
            }

            currentRow += 2;

            worksheet.Cell(currentRow, 1).Value = "CUSTOMERS BY INTERNET SERVICE";
            worksheet.Cell(currentRow, 1).Style.Font.FontSize = 14;
            currentRow += 2;

            worksheet.Cell(currentRow, 1).Value = "Internet Service";
            worksheet.Cell(currentRow, 2).Value = "Customer Count";

            headerRange = worksheet.Range(currentRow, 1, currentRow, 2);
            headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
            currentRow++;

            foreach (var internetService in metrics.CustomersByInternetService.Keys)
            {
                worksheet.Cell(currentRow, 1).Value = internetService;
                worksheet.Cell(currentRow, 2).Value = metrics.CustomersByInternetService[internetService];
                currentRow++;
            }

            worksheet.Columns().AdjustToContents();
        }
    }
}
