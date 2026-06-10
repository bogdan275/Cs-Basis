using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Reporitories;

namespace Services
{
    public class ShelfService
    {
        private readonly IRepository<Shelf> _repository;

        public ShelfService(IRepository<Shelf> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Shelf> GetAllShelves()
        {
            return _repository.GetAll();
        }

        public void AddShelf(Shelf shelf)
        {
            if (string.IsNullOrEmpty(shelf.Zone))
            {
                throw new ArgumentException("Please enter a valid shelf zone.");
            }
            if (shelf.RowNumber < 1 || shelf.ShelfNumber < 1)
            {
                throw new ArgumentException("Row and Shelf numbers must be greater than 0.");
            }

            _repository.Add(shelf);
        }

        public void UpdateShelf(Shelf shelf)
        {
            if (string.IsNullOrEmpty(shelf.Zone))
            {
                throw new ArgumentException("Please enter a valid shelf zone.");
            }
            _repository.Update(shelf);
        }

        public void DeleteShelf(int id)
        {
            _repository.Delete(id);
        }
    }
}