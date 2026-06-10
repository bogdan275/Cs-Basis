using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Core.Entities;
using Domain;
using Domain.Exceptions;

namespace Data.Managers
{
    public class CustomerJsonManager : ICustomerManager
    {
        private readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };

        public List<Customer> Read(string path)
        {
            Logger.LogInfo($"Starting to read JSON file: {path}");

            try
            {
                var jsonString = File.ReadAllText(path);
                var customers = JsonSerializer.Deserialize<List<CustomerJson>>(jsonString, options);

                var result = new List<Customer>();
                int index = 0;

                foreach (var json in customers)
                {
                    try
                    {
                        var customer = MapFromJson(json);
                        CustomerValidator.ValidateCustomer(customer);
                        result.Add(customer);
                    }
                    catch (CustomerDataException ex)
                    {
                        throw new FileReadException(path, $"Error at index {index}: {ex.Message}", ex);
                    }
                    index++;
                }

                return result;
                Logger.LogInfo($"Successfully read JSON file: {path}");
            }
            catch (FileReadException)
            {
                throw;
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to read JSON file: {path}", ex);
                throw new FileReadException(path, "Error reading JSON file", ex);
            }
        }

        public void Write(string path, List<Customer> customers)
        {
            Logger.LogInfo($"Starting to write JSON file: {path}");
            try
            {
                foreach (var customer in customers)
                {
                    CustomerValidator.ValidateCustomer(customer);
                }

                var jsonCustomers = customers.Select(MapToJson).ToList();
                var jsonString = JsonSerializer.Serialize(jsonCustomers, options);
                File.WriteAllText(path, jsonString);

                Logger.LogInfo($"Successfully wrote JSON file: {path}");
            }
            catch (CustomerDataException)
            {
                throw;
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to write JSON file: {path}", ex);
                throw new FileWriteException(path, "Error writing JSON file", ex);
            }
        }

        private Customer MapFromJson(CustomerJson json)
        {
            var customer = new Customer
            {
                CustomerID = json.CustomerID,
                Gender = json.Gender,
                IsSeniorCitizen = json.SeniorCitizen == 1,
                HasPartner = json.Partner == "Yes",
                HasDependents = json.Dependents == "Yes",
                TenureMonths = json.Tenure,
                MonthlyCharges = json.MonthlyCharges,
                TotalCharges = json.TotalCharges,
                HasChurned = json.Churn == "Yes"
            };

            customer.Services.HasPhoneService = json.PhoneService == "Yes";
            customer.Services.MultipleLines = json.MultipleLines;
            customer.Services.InternetService = json.InternetService;
            customer.Services.OnlineSecurity = json.OnlineSecurity;
            customer.Services.OnlineBackup = json.OnlineBackup;
            customer.Services.DeviceProtection = json.DeviceProtection;
            customer.Services.TechSupport = json.TechSupport;
            customer.Services.StreamingTV = json.StreamingTV;
            customer.Services.StreamingMovies = json.StreamingMovies;

            customer.Contract.ContractType = json.Contract;
            customer.Contract.PaperlessBilling = json.PaperlessBilling == "Yes";
            customer.Contract.PaymentMethod = json.PaymentMethod;

            return customer;
        }

        private CustomerJson MapToJson(Customer customer)
        {
            return new CustomerJson
            {
                CustomerID = customer.CustomerID,
                Gender = customer.Gender,
                SeniorCitizen = customer.IsSeniorCitizen ? 1 : 0,
                Partner = customer.HasPartner ? "Yes" : "No",
                Dependents = customer.HasDependents ? "Yes" : "No",
                Tenure = customer.TenureMonths,
                PhoneService = customer.Services.HasPhoneService ? "Yes" : "No",
                MultipleLines = customer.Services.MultipleLines,
                InternetService = customer.Services.InternetService,
                OnlineSecurity = customer.Services.OnlineSecurity,
                OnlineBackup = customer.Services.OnlineBackup,
                DeviceProtection = customer.Services.DeviceProtection,
                TechSupport = customer.Services.TechSupport,
                StreamingTV = customer.Services.StreamingTV,
                StreamingMovies = customer.Services.StreamingMovies,
                Contract = customer.Contract.ContractType,
                PaperlessBilling = customer.Contract.PaperlessBilling ? "Yes" : "No",
                PaymentMethod = customer.Contract.PaymentMethod,
                MonthlyCharges = customer.MonthlyCharges,
                TotalCharges = customer.TotalCharges,
                Churn = customer.HasChurned ? "Yes" : "No"
            };
        }

        private class CustomerJson
        {
            public string CustomerID { get; set; }
            public string Gender { get; set; }
            public int SeniorCitizen { get; set; }
            public string Partner { get; set; }
            public string Dependents { get; set; }
            public int Tenure { get; set; }
            public string PhoneService { get; set; }
            public string MultipleLines { get; set; }
            public string InternetService { get; set; }
            public string OnlineSecurity { get; set; }
            public string OnlineBackup { get; set; }
            public string DeviceProtection { get; set; }
            public string TechSupport { get; set; }
            public string StreamingTV { get; set; }
            public string StreamingMovies { get; set; }
            public string Contract { get; set; }
            public string PaperlessBilling { get; set; }
            public string PaymentMethod { get; set; }
            public decimal MonthlyCharges { get; set; }
            public decimal TotalCharges { get; set; }
            public string Churn { get; set; }
        }
    }
}
