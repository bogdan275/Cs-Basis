using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Reporitories;

namespace Services
{
    public class MedicineService
    {
        private readonly IRepository<Medicine> _medicineRepo;
        private readonly IRepository<Brand> _brandRepo;
        private readonly IRepository<Active_Ingredient> _ingredientRepo;

        public MedicineService(
            IRepository<Medicine> medicineRepo,
            IRepository<Brand> brandRepo,
            IRepository<Active_Ingredient> ingredientRepo)
        {
            _medicineRepo = medicineRepo;
            _brandRepo = brandRepo;
            _ingredientRepo = ingredientRepo;
        }

        public IEnumerable<Medicine> GetAllMedicines()
        {
            return _medicineRepo.GetAll();
        }
        public IEnumerable<Brand> GetAllBrands()
        {
            return _brandRepo.GetAll();
        }
        public IEnumerable<Active_Ingredient> GetAllIngredients()
        {
            return _ingredientRepo.GetAll();
        }

        public void AddMedicine(Medicine medicine)
        {
            if (string.IsNullOrEmpty(medicine.Name) ||
                string.IsNullOrEmpty(medicine.Storage_Conditions) ||
                medicine.Dosage == 0)
            {
                throw new ArgumentException("Please enter a valid medicine name, storage and dosage.");
            }

            _medicineRepo.Add(medicine);
        }

        public void UpdateMedicine(Medicine medicine)
        {
            if (string.IsNullOrEmpty(medicine.Name) ||
                string.IsNullOrEmpty(medicine.Storage_Conditions) ||
                medicine.Dosage == 0)
            {
                throw new ArgumentException("Please enter a valid medicine name, storage and dosage.");
            }

            _medicineRepo.Update(medicine);
        }

        public void DeleteMedicine(int id)
        {
            _medicineRepo.Delete(id);
        }
    }
}