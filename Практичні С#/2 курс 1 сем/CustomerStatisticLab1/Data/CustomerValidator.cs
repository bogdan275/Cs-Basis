using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Domain.Exceptions;

namespace Domain
{
    public static class CustomerValidator
    {
        private static readonly HashSet<string> ValidGenders = new HashSet<string> { "Male", "Female" };
        private static readonly HashSet<string> ValidYesNo = new HashSet<string> { "Yes", "No" };
        private static readonly HashSet<string> ValidServiceStatuses = new HashSet<string>{ "Yes", "No", "No internet service", "No phone service" };
        private static readonly HashSet<string> ValidInternetServices = new HashSet<string>{ "DSL", "Fiber optic", "No" };
        private static readonly HashSet<string> ValidContracts = new HashSet<string>{ "Month-to-month", "One year", "Two year" };
        private static readonly HashSet<string> ValidPaymentMethods = new HashSet<string>{ "Electronic check", "Mailed check", "Bank transfer (automatic)", "Credit card (automatic)" };
        
        public static void ValidateCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new CustomerDataException("Customer cannot be null");
            }
            ValidateRequiredFields(customer);
            ValidateFieldValues(customer);
            ValidateLogicalIntegrity(customer);
        }

        private static void ValidateRequiredFields(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.CustomerID))
            {
                throw new EmptyFieldException("CustomerID");
            }

            if (string.IsNullOrWhiteSpace(customer.Gender))
            {
                throw new EmptyFieldException("Gender");
            }

            if (customer.Services == null)
            {
                throw new CustomerDataException("Services cannot be null");
            }
            if (customer.Contract == null)
            {
                throw new CustomerDataException("Contract cannot be null");
            }
            if (string.IsNullOrWhiteSpace(customer.Services.InternetService))
            {
                throw new EmptyFieldException("InternetService");
            }
            if (string.IsNullOrWhiteSpace(customer.Contract.ContractType))
            {
                throw new EmptyFieldException("ContractType");
            }
            if (string.IsNullOrWhiteSpace(customer.Contract.PaymentMethod))
            {
                throw new EmptyFieldException("PaymentMethod");
            }
        }

        private static void ValidateFieldValues(Customer customer)
        {
            if (!ValidGenders.Contains(customer.Gender))
                throw new InvalidCustomerDataException("Gender", customer.Gender,
                    $"Gender must be one of: {string.Join(", ", ValidGenders)}");

            if (!ValidInternetServices.Contains(customer.Services.InternetService))
                throw new InvalidCustomerDataException("InternetService", customer.Services.InternetService,
                    $"InternetService must be one of: {string.Join(", ", ValidInternetServices)}");

            ValidateServiceStatus("MultipleLines", customer.Services.MultipleLines);
            ValidateServiceStatus("OnlineSecurity", customer.Services.OnlineSecurity);
            ValidateServiceStatus("OnlineBackup", customer.Services.OnlineBackup);
            ValidateServiceStatus("DeviceProtection", customer.Services.DeviceProtection);
            ValidateServiceStatus("TechSupport", customer.Services.TechSupport);
            ValidateServiceStatus("StreamingTV", customer.Services.StreamingTV);
            ValidateServiceStatus("StreamingMovies", customer.Services.StreamingMovies);

            if (!ValidContracts.Contains(customer.Contract.ContractType))
                throw new InvalidCustomerDataException("ContractType", customer.Contract.ContractType,
                    $"ContractType must be one of: {string.Join(", ", ValidContracts)}");

            if (!ValidPaymentMethods.Contains(customer.Contract.PaymentMethod))
                throw new InvalidCustomerDataException("PaymentMethod", customer.Contract.PaymentMethod,
                    $"PaymentMethod must be one of: {string.Join(", ", ValidPaymentMethods)}");
        }

        private static void ValidateServiceStatus(string fieldName, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new EmptyFieldException(fieldName);

            if (!ValidServiceStatuses.Contains(value))
                throw new InvalidCustomerDataException(fieldName, value,
                    $"{fieldName} must be one of: {string.Join(", ", ValidServiceStatuses)}");
        }

        private static void ValidateLogicalIntegrity(Customer customer)
        {
            if (!customer.Services.HasPhoneService)
            {
                if (customer.Services.MultipleLines != "No phone service")
                    throw new CustomerDataException("MultipleLines must be 'No phone service' when PhoneService is No");
            }

            if (customer.Services.InternetService == "No")
            {
                string[] internetServices = {
                    customer.Services.OnlineSecurity,
                    customer.Services.OnlineBackup,
                    customer.Services.DeviceProtection,
                    customer.Services.TechSupport,
                    customer.Services.StreamingTV,
                    customer.Services.StreamingMovies
                };

                foreach (var service in internetServices)
                {
                    if (service != "No internet service")
                        throw new CustomerDataException("Internet-dependent services must be 'No internet service' when InternetService is No");
                }
            }

            decimal expectedMinTotal = customer.MonthlyCharges * customer.TenureMonths * 0.8m;
            if (customer.TotalCharges < expectedMinTotal && customer.TenureMonths > 0)
            {
                throw new CustomerDataException($"TotalCharges ({customer.TotalCharges}) seems inconsistent with MonthlyCharges ({customer.MonthlyCharges}) and Tenure ({customer.TenureMonths})");
            }
        }

        public static void ValidateUniqueCustomerID(string customerID, List<Customer> existingCustomers)
        {
            if (existingCustomers.Any(c => c.CustomerID == customerID))
            {
                throw new DuplicateCustomerException(customerID);
            }
        }

        public static void ValidateCustomerExists(string customerID, List<Customer> existingCustomers)
        {
            if (!existingCustomers.Any(c => c.CustomerID == customerID))
            {
                throw new CustomerNotFoundException(customerID);
            }
        }

        public static bool IsCustomerIDValid(string customerID)
        {
            return !string.IsNullOrWhiteSpace(customerID);
        }

        public static List<string> GetValidValuesForField(string fieldName)
        {

            switch (fieldName)
            {
                case "Gender":
                    {
                        return new List<string>(ValidGenders);
                    }
                case "InternetService":
                    {
                        return new List<string>(ValidInternetServices);
                    }
                case "ServiceStatus":
                    {
                        return new List<string>(ValidServiceStatuses);
                    }
                case "ContractType":
                    {
                        return new List<string>(ValidContracts);
                    }
                case "PaymentMethod":
                    {
                        return new List<string>(ValidPaymentMethods);
                    }
                default:
                    {
                        return new List<string>();
                    }
            }
        }
    }
}
