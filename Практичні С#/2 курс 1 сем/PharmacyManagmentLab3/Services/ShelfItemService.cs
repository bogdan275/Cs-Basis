using System;
using System.Collections.Generic;
using Data.Models;
using Repositories.Reporitories;

namespace Services
{
    public class ShelfItemService
    {
        private readonly IRepository<Shelf_Item> _shelfItemRepo;
        private readonly IRepository<Medicine> _medicineRepo;
        private readonly IRepository<Shelf> _shelfRepo;

        public ShelfItemService(
            IRepository<Shelf_Item> shelfItemRepo,
            IRepository<Medicine> medicineRepo,
            IRepository<Shelf> shelfRepo)
        {
            _shelfItemRepo = shelfItemRepo;
            _medicineRepo = medicineRepo;
            _shelfRepo = shelfRepo;
        }

        public IEnumerable<Shelf_Item> GetAllShelfItems()
        {
            return _shelfItemRepo.GetAll();
        }
        public IEnumerable<Medicine> GetAllMedicines()
        {
            return _medicineRepo.GetAll();
        }
        public IEnumerable<Shelf> GetAllShelves()
        {
            return _shelfRepo.GetAll();
        }

        public void AddShelfItem(Shelf_Item item)
        {
            ValidateShelfItem(item);
            _shelfItemRepo.Add(item);
        }

        public void UpdateShelfItem(Shelf_Item item)
        {
            ValidateShelfItem(item);
            _shelfItemRepo.Update(item);
        }

        public void DeleteShelfItem(int id)
        {
            _shelfItemRepo.Delete(id);
        }

        private void ValidateShelfItem(Shelf_Item item)
        {
            if (item.Medicine == null)
            {
                throw new ArgumentException("Please select a medicine.");
            }
            if (item.Shelf == null)
            {
                throw new ArgumentException("Please select a shelf.");
            }
            if (item.Face_Current < 0 || item.Face_Required < 0)
            {
                throw new ArgumentException("Faces cannot be negative.");
            }
        }
    }
}