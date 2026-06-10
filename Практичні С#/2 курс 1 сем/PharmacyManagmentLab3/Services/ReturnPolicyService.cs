using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Reporitories;

namespace Services
{
    public class ReturnPolicyService
    {
        private readonly IRepository<Return_Policy> _returnPolicyRepo;
        private readonly IRepository<Sale> _saleRepo;

        public ReturnPolicyService(
            IRepository<Return_Policy> returnPolicyRepo,
            IRepository<Sale> saleRepo)
        {
            _returnPolicyRepo = returnPolicyRepo;
            _saleRepo = saleRepo;
        }

        public IEnumerable<Return_Policy> GetAllPolicies()
        {
            return _returnPolicyRepo.GetAll();
        }
        public IEnumerable<Sale> GetAllSales()
        {
            return _saleRepo.GetAll();
        }

        public void AddReturnPolicy(Return_Policy policy)
        {
            ValidatePolicy(policy);
            _returnPolicyRepo.Add(policy);
        }

        public void UpdateReturnPolicy(Return_Policy policy)
        {
            ValidatePolicy(policy);
            _returnPolicyRepo.Update(policy);
        }

        public void DeleteReturnPolicy(int id)
        {
            _returnPolicyRepo.Delete(id);
        }

        private void ValidatePolicy(Return_Policy policy)
        {
            if (string.IsNullOrEmpty(policy.Signature1) ||
                string.IsNullOrEmpty(policy.Signature2) ||
                string.IsNullOrEmpty(policy.Pasport_Data))
            {
                throw new ArgumentException("Please enter valid data (Signatures and Passport Data are required).");
            }

            if (policy.Sale == null)
            {
                throw new ArgumentException("Please select a sale.");
            }
        }
    }
}