using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Main;

namespace Services
{
    public class ClientService
    {
        private readonly ClientRepo _clientRepo;
        private readonly TariffPlanRepo _tariffRepo;

        public ClientService(ClientRepo clientRepo, TariffPlanRepo tariffRepo)
        {
            _clientRepo = clientRepo;
            _tariffRepo = tariffRepo;
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientRepo.GetAll(); 
        }
        public IEnumerable<TariffPlan> GetTariffs()
        {
            return _tariffRepo.GetAll();
        }

        public void Create(string companyName, string phone, string email, int tariffId)
        {
            if (string.IsNullOrWhiteSpace(companyName))
            {
                throw new ArgumentException("Company Name is required.");
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                throw new ArgumentException("Phone is required.");
            }
            if (tariffId <= 0)
            {
                throw new ArgumentException("Tariff Plan is required.");
            }

            var newClient = new Client
            {
                CompanyName = companyName,
                Phone = phone,
                Email = email,
                TariffPlanId = tariffId
            };

            _clientRepo.Add(newClient);
        }

        public void Update(Client client, string companyName, string phone, string email, int tariffId)
        {
            if (string.IsNullOrWhiteSpace(companyName))
            {
                throw new ArgumentException("Company Name is required.");
            }

            client.CompanyName = companyName;
            client.Phone = phone;
            client.Email = email;
            client.TariffPlanId = tariffId;

            _clientRepo.Update(client);
        }

        public void Delete(int id)
        {
            _clientRepo.Delete(id);
        }
    }
}