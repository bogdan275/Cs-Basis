using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using Core.Entities;
using Domain;

namespace Data.Managers
{
    public class CustomerXmlManager : ICustomerManager
    {
        public List<Customer> Read(string path)
        {
            Logger.LogInfo($"Starting to read XML file: {path}");
            try
            {
                XDocument xdoc = XDocument.Load(path);
                var customers = new List<Customer>();

                var customerElements = xdoc.Root.Elements("customer");

                foreach (var element in customerElements)
                {
                    var customer = new Customer
                    {
                        CustomerID = element.Attribute("id")?.Value,
                        Gender = element.Element("gender")?.Value,
                        IsSeniorCitizen = element.Element("seniorCitizen")?.Value == "1",
                        HasPartner = element.Element("partner")?.Value == "Yes",
                        HasDependents = element.Element("dependents")?.Value == "Yes",
                        TenureMonths = int.Parse(element.Element("tenure")?.Value ?? "0"),
                        MonthlyCharges = decimal.Parse(element.Element("monthlyCharges")?.Value ?? "0"),
                        TotalCharges = decimal.Parse(element.Element("totalCharges")?.Value ?? "0"),
                        HasChurned = element.Element("churn")?.Value == "Yes"
                    };

                    var services = element.Element("services");
                    if (services != null)
                    {
                        customer.Services.HasPhoneService = services.Element("phoneService")?.Value == "Yes";
                        customer.Services.MultipleLines = services.Element("multipleLines")?.Value;
                        customer.Services.InternetService = services.Element("internetService")?.Value;
                        customer.Services.OnlineSecurity = services.Element("onlineSecurity")?.Value;
                        customer.Services.OnlineBackup = services.Element("onlineBackup")?.Value;
                        customer.Services.DeviceProtection = services.Element("deviceProtection")?.Value;
                        customer.Services.TechSupport = services.Element("techSupport")?.Value;
                        customer.Services.StreamingTV = services.Element("streamingTV")?.Value;
                        customer.Services.StreamingMovies = services.Element("streamingMovies")?.Value;
                    }

                    var contract = element.Element("contract");
                    if (contract != null)
                    {
                        customer.Contract.ContractType = contract.Element("type")?.Value;
                        customer.Contract.PaperlessBilling = contract.Element("paperlessBilling")?.Value == "Yes";
                        customer.Contract.PaymentMethod = contract.Element("paymentMethod")?.Value;
                    }

                    customers.Add(customer);
                }

                return customers;

                Logger.LogInfo($"Successfully read XML file: {path}");
            }
            catch (FileNotFoundException)
            {
                throw;
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to read XML file: {path}", ex);
                throw new Exception($"Error reading XML file: {ex.Message}", ex);
            }
        }

        public void Write(string path, List<Customer> customers)
        {
            try
            {
                Logger.LogInfo($"Starting to write XML file: {path}");

                var root = new XElement("customers");

                foreach (var customer in customers)
                {
                    var customerElement = new XElement("customer",
                        new XAttribute("id", customer.CustomerID),
                        new XElement("gender", customer.Gender),
                        new XElement("seniorCitizen", customer.IsSeniorCitizen ? "1" : "0"),
                        new XElement("partner", customer.HasPartner ? "Yes" : "No"),
                        new XElement("dependents", customer.HasDependents ? "Yes" : "No"),
                        new XElement("tenure", customer.TenureMonths),

                        new XElement("services",
                            new XElement("phoneService", customer.Services.HasPhoneService ? "Yes" : "No"),
                            new XElement("multipleLines", customer.Services.MultipleLines),
                            new XElement("internetService", customer.Services.InternetService),
                            new XElement("onlineSecurity", customer.Services.OnlineSecurity),
                            new XElement("onlineBackup", customer.Services.OnlineBackup),
                            new XElement("deviceProtection", customer.Services.DeviceProtection),
                            new XElement("techSupport", customer.Services.TechSupport),
                            new XElement("streamingTV", customer.Services.StreamingTV),
                            new XElement("streamingMovies", customer.Services.StreamingMovies)
                        ),

                        new XElement("contract",
                            new XElement("type", customer.Contract.ContractType),
                            new XElement("paperlessBilling", customer.Contract.PaperlessBilling ? "Yes" : "No"),
                            new XElement("paymentMethod", customer.Contract.PaymentMethod)
                        ),

                        new XElement("monthlyCharges", customer.MonthlyCharges),
                        new XElement("totalCharges", customer.TotalCharges),
                        new XElement("churn", customer.HasChurned ? "Yes" : "No")
                    );

                    root.Add(customerElement);
                }

                var xdoc = new XDocument(new XDeclaration("1.0", "UTF-8", null), root);
                xdoc.Save(path);

                Logger.LogInfo($"Successfully wrote XML file: {path}");
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to write XML file: {path}", ex);
                throw new Exception($"Error writing XML file: {ex.Message}", ex);
            }
        }
    }
}
