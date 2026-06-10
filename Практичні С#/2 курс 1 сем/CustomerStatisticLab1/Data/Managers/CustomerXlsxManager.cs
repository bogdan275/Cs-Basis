using System;
using System.Collections.Generic;
using System.Text;
using ClosedXML.Excel;
using Core.Entities;
using Domain;
using Domain.Exceptions;

namespace Data.Managers
{
    public class CustomerXlsxManager : ICustomerManager
    {
        public List<Customer> Read(string path)
        {
            Logger.LogInfo($"Starting to read XLSX file: {path}");
            var customers = new List<Customer>();

            try
            {
                using (var workbook = new XLWorkbook(path))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RangeUsed().RowsUsed().Skip(1);

                    foreach (var row in rows)
                    {
                        var customer = new Customer
                        {
                            CustomerID = row.Cell(1).GetString(),
                            Gender = row.Cell(2).GetString(),
                            IsSeniorCitizen = row.Cell(3).GetValue<int>() == 1,
                            HasPartner = row.Cell(4).GetString() == "Yes",
                            HasDependents = row.Cell(5).GetString() == "Yes",
                            TenureMonths = row.Cell(6).GetValue<int>(),
                            MonthlyCharges = row.Cell(19).GetValue<decimal>(),
                            TotalCharges = row.Cell(20).GetValue<decimal>(),
                            HasChurned = row.Cell(21).GetString() == "Yes"
                        };

                        customer.Services.HasPhoneService = row.Cell(7).GetString() == "Yes";
                        customer.Services.MultipleLines = row.Cell(8).GetString();
                        customer.Services.InternetService = row.Cell(9).GetString();
                        customer.Services.OnlineSecurity = row.Cell(10).GetString();
                        customer.Services.OnlineBackup = row.Cell(11).GetString();
                        customer.Services.DeviceProtection = row.Cell(12).GetString();
                        customer.Services.TechSupport = row.Cell(13).GetString();
                        customer.Services.StreamingTV = row.Cell(14).GetString();
                        customer.Services.StreamingMovies = row.Cell(15).GetString();

                        customer.Contract.ContractType = row.Cell(16).GetString();
                        customer.Contract.PaperlessBilling = row.Cell(17).GetString() == "Yes";
                        customer.Contract.PaymentMethod = row.Cell(18).GetString();

                        customers.Add(customer);
                    }
                }

                return customers;

                Logger.LogInfo($"Successfully read XLSX file: {path}");
            }
            catch (FileReadException)
            {
                throw;
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to read XLSX file: {path}", ex);
                throw new Exception($"Error reading XLSX file at {path}: {ex.Message}", ex);
            }
        }

        public void Write(string path, List<Customer> customers)
        {
            Logger.LogInfo($"Starting to write XLSX file: {path}");
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Customers");

                    worksheet.Cell(1, 1).Value = "customerID";
                    worksheet.Cell(1, 2).Value = "gender";
                    worksheet.Cell(1, 3).Value = "SeniorCitizen";
                    worksheet.Cell(1, 4).Value = "Partner";
                    worksheet.Cell(1, 5).Value = "Dependents";
                    worksheet.Cell(1, 6).Value = "tenure";
                    worksheet.Cell(1, 7).Value = "PhoneService";
                    worksheet.Cell(1, 8).Value = "MultipleLines";
                    worksheet.Cell(1, 9).Value = "InternetService";
                    worksheet.Cell(1, 10).Value = "OnlineSecurity";
                    worksheet.Cell(1, 11).Value = "OnlineBackup";
                    worksheet.Cell(1, 12).Value = "DeviceProtection";
                    worksheet.Cell(1, 13).Value = "TechSupport";
                    worksheet.Cell(1, 14).Value = "StreamingTV";
                    worksheet.Cell(1, 15).Value = "StreamingMovies";
                    worksheet.Cell(1, 16).Value = "Contract";
                    worksheet.Cell(1, 17).Value = "PaperlessBilling";
                    worksheet.Cell(1, 18).Value = "PaymentMethod";
                    worksheet.Cell(1, 19).Value = "MonthlyCharges";
                    worksheet.Cell(1, 20).Value = "TotalCharges";
                    worksheet.Cell(1, 21).Value = "Churn";

                    var headerRange = worksheet.Range(1, 1, 1, 21);

                    int rowIndex = 2;
                    foreach (var customer in customers)
                    {
                        worksheet.Cell(rowIndex, 1).Value = customer.CustomerID;
                        worksheet.Cell(rowIndex, 2).Value = customer.Gender;
                        worksheet.Cell(rowIndex, 3).Value = customer.IsSeniorCitizen ? 1 : 0;
                        worksheet.Cell(rowIndex, 4).Value = customer.HasPartner ? "Yes" : "No";
                        worksheet.Cell(rowIndex, 5).Value = customer.HasDependents ? "Yes" : "No";
                        worksheet.Cell(rowIndex, 6).Value = customer.TenureMonths;
                        worksheet.Cell(rowIndex, 7).Value = customer.Services.HasPhoneService ? "Yes" : "No";
                        worksheet.Cell(rowIndex, 8).Value = customer.Services.MultipleLines;
                        worksheet.Cell(rowIndex, 9).Value = customer.Services.InternetService;
                        worksheet.Cell(rowIndex, 10).Value = customer.Services.OnlineSecurity;
                        worksheet.Cell(rowIndex, 11).Value = customer.Services.OnlineBackup;
                        worksheet.Cell(rowIndex, 12).Value = customer.Services.DeviceProtection;
                        worksheet.Cell(rowIndex, 13).Value = customer.Services.TechSupport;
                        worksheet.Cell(rowIndex, 14).Value = customer.Services.StreamingTV;
                        worksheet.Cell(rowIndex, 15).Value = customer.Services.StreamingMovies;
                        worksheet.Cell(rowIndex, 16).Value = customer.Contract.ContractType;
                        worksheet.Cell(rowIndex, 17).Value = customer.Contract.PaperlessBilling ? "Yes" : "No";
                        worksheet.Cell(rowIndex, 18).Value = customer.Contract.PaymentMethod;
                        worksheet.Cell(rowIndex, 19).Value = customer.MonthlyCharges;
                        worksheet.Cell(rowIndex, 20).Value = customer.TotalCharges;
                        worksheet.Cell(rowIndex, 21).Value = customer.HasChurned ? "Yes" : "No";

                        rowIndex++;
                    }

                    worksheet.Columns().AdjustToContents();
                    workbook.SaveAs(path);
                }
                Logger.LogInfo($"Successfully wrote XLSX file: {path}");
            }
            catch (CustomerDataException)
            {
                throw;
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to write XLSX file: {path}", ex);
                throw new Exception($"Error writing XLSX file at {path}: {ex.Message}", ex);
            }
        }
    }
}
