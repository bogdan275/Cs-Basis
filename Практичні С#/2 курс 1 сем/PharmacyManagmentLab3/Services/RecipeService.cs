using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Reporitories;

namespace Services
{
    public class RecipeService
    {
        private readonly IRepository<Recipe> _recipeRepo;
        private readonly IRepository<Medicine> _medicineRepo;

        public RecipeService(IRepository<Recipe> recipeRepo, IRepository<Medicine> medicineRepo)
        {
            _recipeRepo = recipeRepo;
            _medicineRepo = medicineRepo;
        }

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _recipeRepo.GetAll();
        }
        public IEnumerable<Medicine> GetAllMedicines()
        {
            return _medicineRepo.GetAll();
        }

        public void AddRecipe(Recipe recipe)
        {
            if (string.IsNullOrEmpty(recipe.Doctor_Name) || string.IsNullOrEmpty(recipe.Doctor_Phone))
            {
                throw new ArgumentException("Please enter doctor name and phone.");
            }

            _recipeRepo.Add(recipe);
        }

        public void UpdateRecipe(Recipe recipe)
        {
            if (string.IsNullOrEmpty(recipe.Doctor_Name) || string.IsNullOrEmpty(recipe.Doctor_Phone))
            {
                throw new ArgumentException("Please enter doctor name and phone.");
            }

            _recipeRepo.Update(recipe);
        }

        public void DeleteRecipe(int id)
        {
            _recipeRepo.Delete(id);
        }
    }
}