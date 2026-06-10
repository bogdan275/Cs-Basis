using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Core.Entities;
using CsvHelper;
using CsvHelper.Configuration;
using Domain;
using Domain.Exceptions;

namespace Data.Managers
{
    public class CustomerCsvManager : ICustomerManager
    {
        private CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true
        };

        public List<Customer> Read(string path)
        {
            Logger.LogInfo($"Starting to read CSV file: {path}");

            var customers = new List<Customer>();
            int skipped = 0;

            try
            {
                using (var reader = new StreamReader(path))
                using (var csv = new CsvReader(reader, config))
                {
                    csv.Read();
                    csv.ReadHeader();

                    int rowNumber = 2;

                    while (csv.Read())
                    {
                        try
                        {
                            // Read as strings first and parse safely
                            var id = csv.GetField<string>("customerID");
                            var gender = csv.GetField<string>("gender");
                            var seniorStr = csv.GetField<string>("SeniorCitizen");
                            var partner = csv.GetField<string>("Partner");
                            var dependents = csv.GetField<string>("Dependents");
                            var tenureStr = csv.GetField<string>("tenure");
                            var phoneService = csv.GetField<string>("PhoneService");
                            var multipleLines = csv.GetField<string>("MultipleLines");
                            var internetService = csv.GetField<string>("InternetService");
                            var onlineSecurity = csv.GetField<string>("OnlineSecurity");
                            var onlineBackup = csv.GetField<string>("OnlineBackup");
                            var deviceProtection = csv.GetField<string>("DeviceProtection");
                            var techSupport = csv.GetField<string>("TechSupport");
                            var streamingTV = csv.GetField<string>("StreamingTV");
                            var streamingMovies = csv.GetField<string>("StreamingMovies");
                            var contract = csv.GetField<string>("Contract");
                            var paperless = csv.GetField<string>("PaperlessBilling");
                            var paymentMethod = csv.GetField<string>("PaymentMethod");
                            var monthlyStr = csv.GetField<string>("MonthlyCharges");
                            var totalStr = csv.GetField<string>("TotalCharges");
                            var churn = csv.GetField<string>("Churn");

                            if (!int.TryParse(seniorStr, out var seniorInt))
                            {
                                seniorInt = 0; 
                            }

                            if (!int.TryParse(tenureStr, out var tenure))
                            {
                                Logger.LogWarning($"Skipping row {rowNumber}: invalid tenure value '{tenureStr}'");
                                skipped++;
                                rowNumber++;
                                continue;
                            }

                            if (!decimal.TryParse(monthlyStr, NumberStyles.Any, CultureInfo.InvariantCulture, out var monthly))
                            {
                                Logger.LogWarning($"Skipping row {rowNumber}: invalid MonthlyCharges '{monthlyStr}'");
                                skipped++;
                                rowNumber++;
                                continue;
                            }

                            decimal total = 0m;
                            if (string.IsNullOrWhiteSpace(totalStr))
                            {
                                total = tenure > 0 ? monthly * tenure : 0m;
                                Logger.LogWarning($"Row {rowNumber}: TotalCharges empty, set to {total} (MonthlyCharges*tenure)");
                            }
                            else if (!decimal.TryParse(totalStr, NumberStyles.Any, CultureInfo.InvariantCulture, out total))
                            {
                                Logger.LogWarning($"Skipping row {rowNumber}: invalid TotalCharges '{totalStr}'");
                                skipped++;
                                rowNumber++;
                                continue;
                            }

                            var customer = new Customer
                            {
                                CustomerID = id,
                                Gender = gender,
                                IsSeniorCitizen = seniorInt == 1,
                                HasPartner = partner == "Yes",
                                HasDependents = dependents == "Yes",
                                TenureMonths = tenure,
                                MonthlyCharges = monthly,
                                TotalCharges = total,
                                HasChurned = churn == "Yes"
                            };

                            customer.Services.HasPhoneService = phoneService == "Yes";
                            customer.Services.MultipleLines = multipleLines;
                            customer.Services.InternetService = internetService;
                            customer.Services.OnlineSecurity = onlineSecurity;
                            customer.Services.OnlineBackup = onlineBackup;
                            customer.Services.DeviceProtection = deviceProtection;
                            customer.Services.TechSupport = techSupport;
                            customer.Services.StreamingTV = streamingTV;
                            customer.Services.StreamingMovies = streamingMovies;

                            customer.Contract.ContractType = contract;
                            customer.Contract.PaperlessBilling = paperless == "Yes";
                            customer.Contract.PaymentMethod = paymentMethod;

                            try
                            {
                                CustomerValidator.ValidateCustomer(customer);
                                customers.Add(customer);
                            }
                            catch (CustomerDataException ex)
                            {
                                Logger.LogWarning($"Skipping invalid row {rowNumber} (CustomerID='{id}'): {ex.Message}");
                                skipped++;
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.LogWarning($"Skipping row {rowNumber} due to parsing error: {ex.Message}");
                            skipped++;
                        }

                        rowNumber++;
                    }
                }

                Logger.LogInfo($"Finished reading CSV file: {path}. Loaded {customers.Count} rows, skipped {skipped} rows.");
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to read CSV file: {path}", ex);
                throw new FileReadException(path, "Error reading CSV file", ex);
            }

            return customers;
        }

        public void Write(string path, List<Customer> customers)
        {
            Logger.LogInfo($"Starting to write {customers.Count} customers to CSV file: {path}");

            try
            {
                foreach (var customer in customers)
                {
                    CustomerValidator.ValidateCustomer(customer);
                }

                using (var writer = new StreamWriter(path))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteField("customerID");
                    csv.WriteField("gender");
                    csv.WriteField("SeniorCitizen");
                    csv.WriteField("Partner");
                    csv.WriteField("Dependents");
                    csv.WriteField("tenure");
                    csv.WriteField("PhoneService");
                    csv.WriteField("MultipleLines");
                    csv.WriteField("InternetService");
                    csv.WriteField("OnlineSecurity");
                    csv.WriteField("OnlineBackup");
                    csv.WriteField("DeviceProtection");
                    csv.WriteField("TechSupport");
                    csv.WriteField("StreamingTV");
                    csv.WriteField("StreamingMovies");
                    csv.WriteField("Contract");
                    csv.WriteField("PaperlessBilling");
                    csv.WriteField("PaymentMethod");
                    csv.WriteField("MonthlyCharges");
                    csv.WriteField("TotalCharges");
                    csv.WriteField("Churn");
                    csv.NextRecord();

                    foreach (var customer in customers)
                    {
                        csv.WriteField(customer.CustomerID);
                        csv.WriteField(customer.Gender);
                        csv.WriteField(customer.IsSeniorCitizen ? "1" : "0");
                        csv.WriteField(customer.HasPartner ? "Yes" : "No");
                        csv.WriteField(customer.HasDependents ? "Yes" : "No");
                        csv.WriteField(customer.TenureMonths);
                        csv.WriteField(customer.Services.HasPhoneService ? "Yes" : "No");
                        csv.WriteField(customer.Services.MultipleLines);
                        csv.WriteField(customer.Services.InternetService);
                        csv.WriteField(customer.Services.OnlineSecurity);
                        csv.WriteField(customer.Services.OnlineBackup);
                        csv.WriteField(customer.Services.DeviceProtection);
                        csv.WriteField(customer.Services.TechSupport);
                        csv.WriteField(customer.Services.StreamingTV);
                        csv.WriteField(customer.Services.StreamingMovies);
                        csv.WriteField(customer.Contract.ContractType);
                        csv.WriteField(customer.Contract.PaperlessBilling ? "Yes" : "No");
                        csv.WriteField(customer.Contract.PaymentMethod);
                        csv.WriteField(customer.MonthlyCharges);
                        csv.WriteField(customer.TotalCharges);
                        csv.WriteField(customer.HasChurned ? "Yes" : "No");
                        csv.NextRecord();
                    }
                }
                Logger.LogInfo($"Successfully wrote {customers.Count} customers to CSV file: {path}");
            }
            catch (CustomerDataException)
            {
                throw; 
            }
            catch (Exception ex)
            {
                Logger.LogError($"Validation error while writing to CSV file: {path}", ex);
                throw new FileWriteException(path, "Error writing CSV file", ex);
            }
        }
    }
}
