using System;
using System.Collections.Generic;
using System.Linq;
using Data.Models;
using Repositories.Main;

namespace Services
{
    public class InventoryItemService
    {
        private readonly InventoryItemRepo _invRepo;
        private readonly StockMovementRepo _moveRepo;

        public InventoryItemService(InventoryItemRepo invRepo, StockMovementRepo moveRepo)
        {
            _invRepo = invRepo;
            _moveRepo = moveRepo;
        }

        public IEnumerable<InventoryItem> GetAll()
        {
            return _invRepo.GetAll();
        }

        public void ReceiveStock(int productId, int binId, int qty)
        {
            if (qty <= 0) throw new Exception("Quantity must be positive.");

            var item = _invRepo.GetAll().FirstOrDefault(x => x.ProductId == productId && x.StorageBinId == binId);

            if (item != null)
            {
                item.Quantity += qty;
                item.ArrivalDate = DateTime.Now;
                _invRepo.Update(item);
            }
            else
            {
                _invRepo.Add(new InventoryItem
                {
                    ProductId = productId,
                    StorageBinId = binId,
                    Quantity = qty,
                    ArrivalDate = DateTime.Now
                });
            }

            _moveRepo.Add(new StockMovement
            {
                ProductId = productId,
                ToBinId = binId,
                Quantity = qty,
                Type = "Inbound",
                MovementDate = DateTime.Now
            });
        }

        public void ShipStock(int productId, int binId, int qty)
        {
            if (qty <= 0) throw new Exception("Quantity must be positive.");

            var item = _invRepo.GetAll().FirstOrDefault(x => x.ProductId == productId && x.StorageBinId == binId);

            if (item == null || item.Quantity < qty)
                throw new Exception("Not enough stock.");

            item.Quantity -= qty;

            if (item.Quantity == 0) _invRepo.Delete(item.Id);
            else _invRepo.Update(item);

            _moveRepo.Add(new StockMovement
            {
                ProductId = productId,
                FromBinId = binId,
                Quantity = qty,
                Type = "Outbound",
                MovementDate = DateTime.Now
            });
        }

        public void RelocateStock(int productId, int fromId, int toId, int qty)
        {
            if (qty <= 0) throw new Exception("Quantity must be positive.");
            if (fromId == toId) return;

            var source = _invRepo.GetAll().FirstOrDefault(x => x.ProductId == productId && x.StorageBinId == fromId);
            if (source == null || source.Quantity < qty) throw new Exception("Not enough stock.");

            source.Quantity -= qty;
            if (source.Quantity == 0) _invRepo.Delete(source.Id);
            else _invRepo.Update(source);

            var target = _invRepo.GetAll().FirstOrDefault(x => x.ProductId == productId && x.StorageBinId == toId);
            if (target != null)
            {
                target.Quantity += qty;
                _invRepo.Update(target);
            }
            else
            {
                _invRepo.Add(new InventoryItem { ProductId = productId, StorageBinId = toId, Quantity = qty, ArrivalDate = DateTime.Now });
            }

            _moveRepo.Add(new StockMovement
            {
                ProductId = productId,
                FromBinId = fromId,
                ToBinId = toId,
                Quantity = qty,
                Type = "Relocation",
                MovementDate = DateTime.Now
            });
        }
    }
}