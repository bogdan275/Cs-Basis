using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Reporitories;

namespace Services
{
    public class ActiveIngredientService
    {
        private readonly IRepository<Active_Ingredient> _repository;

        public ActiveIngredientService(IRepository<Active_Ingredient> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Active_Ingredient> GetAll()
        {
            return _repository.GetAll();
        }

        public void Create(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Please enter a valid active ingredient name.");
            }

            var newIngredient = new Active_Ingredient { Name = name };
            _repository.Add(newIngredient);
        }

        public void Update(Active_Ingredient ingredient, string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("Please enter a valid active ingredient name.");
            }

            ingredient.Name = newName;
            _repository.Update(ingredient);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}