using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Domain.Reports
{
    public class CustomerMetrics
    {
        public int TotalCustomers { get; set; }
        public decimal ChurnRate { get; set; }
        public decimal SeniorCitizenPercentage { get; set; }

        public int SeniorCitizensCount { get; set; }
        public int SeniorCitizensWithDependents { get; set; }
        public int SeniorCitizensWithPartner { get; set; }
        public decimal AverageTenure { get; set; }
        public decimal AverageMonthlyCharges { get; set; }
        public decimal AverageTotalCharges { get; set; }

        public Dictionary<string, int> CustomersByContractType { get; set; }
        public Dictionary<string, decimal> AverageMonthlyChargesByContract { get; set; }

        public int CustomersWithPartner { get; set; }
        public int CustomersWithDependents { get; set; }
        public int CustomersWithPhoneService { get; set; }
        public Dictionary<string, int> CustomersByInternetService { get; set; }
        public Dictionary<string, decimal> ChurnRateByContractType { get; set; }

        public CustomerMetrics()
        {
            CustomersByContractType = new Dictionary<string, int>();
            AverageMonthlyChargesByContract = new Dictionary<string, decimal>();
            CustomersByInternetService = new Dictionary<string, int>();
            ChurnRateByContractType = new Dictionary<string, decimal>();
        }

        public static CustomerMetrics Calculate(List<Customer> customers)
        {
            if (customers == null || customers.Count == 0)
                return new CustomerMetrics();

            var metrics = new CustomerMetrics();

            metrics.TotalCustomers = customers.Count;
            metrics.ChurnRate = (decimal)customers.Count(c => c.HasChurned) / customers.Count * 100;

            var seniorCitizens = customers.Where(c => c.IsSeniorCitizen).ToList();
            metrics.SeniorCitizensCount = seniorCitizens.Count;
            metrics.SeniorCitizenPercentage = (decimal)seniorCitizens.Count / customers.Count * 100;
            metrics.SeniorCitizensWithDependents = seniorCitizens.Count(c => c.HasDependents);
            metrics.SeniorCitizensWithPartner = seniorCitizens.Count(c => c.HasPartner);

            metrics.AverageTenure = (decimal)customers.Average(c => c.TenureMonths);
            metrics.AverageMonthlyCharges = customers.Average(c => c.MonthlyCharges);
            metrics.AverageTotalCharges = customers.Average(c => c.TotalCharges);

            var contractGroups = customers.GroupBy(c => c.Contract.ContractType);
            foreach (var group in contractGroups)
            {
                metrics.CustomersByContractType[group.Key] = group.Count();
                metrics.AverageMonthlyChargesByContract[group.Key] = group.Average(c => c.MonthlyCharges);

                int churnedInGroup = group.Count(c => c.HasChurned);
                metrics.ChurnRateByContractType[group.Key] = (decimal)churnedInGroup / group.Count() * 100;
            }

            metrics.CustomersWithPartner = customers.Count(c => c.HasPartner);
            metrics.CustomersWithDependents = customers.Count(c => c.HasDependents);
            metrics.CustomersWithPhoneService = customers.Count(c => c.Services.HasPhoneService);

            var internetGroups = customers.GroupBy(c => c.Services.InternetService);
            foreach (var group in internetGroups)
            {
                metrics.CustomersByInternetService[group.Key] = group.Count();
            }

            return metrics;
        }
    }
}
