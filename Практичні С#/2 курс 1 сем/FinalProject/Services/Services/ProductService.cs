using System;
using System.Collections.Generic;
using System.Linq;
using Data.Models;
using Repositories.Main;

namespace Services
{
    public class ProductService
    {
        private readonly ProductRepo _productRepo;
        private readonly ClientRepo _clientRepo;

        public ProductService(ProductRepo productRepo, ClientRepo clientRepo)
        {
            _productRepo = productRepo;
            _clientRepo = clientRepo;
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepo.GetAll();
        }

        public void Create(string name, string sku, string description,
                           decimal len, decimal wid, decimal hgt, decimal wgt, int clientId)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name is required.");
            }
            if (string.IsNullOrWhiteSpace(sku))
            {
                throw new ArgumentException("SKU is required.");
            }
            if (string.IsNullOrWhiteSpace(description)) description = "No description";

            if (clientId <= 0)
            {
                throw new ArgumentException("Client is required.");
            }

            if (_productRepo.GetAll().Any(x => x.SKU == sku))
            {
                throw new ArgumentException($"SKU '{sku}' already exists.");
            }

            var newProduct = new Product
            {
                Name = name,
                SKU = sku,
                Description = description,
                Length = len,
                Width = wid,
                Height = hgt,
                Weight = wgt,
                ClientId = clientId
            };

            _productRepo.Add(newProduct);
        }

        public void Update(Product product, string name, string sku, string description,
                           decimal len, decimal wid, decimal hgt, decimal wgt, int clientId)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name is required.");
            }

            if (clientId <= 0)
            {
                throw new ArgumentException("Client is required.");
            }

            if (_productRepo.GetAll().Any(x => x.SKU == sku && x.Id != product.Id))
            {
                throw new ArgumentException($"SKU '{sku}' is taken.");
            }

            product.Name = name;
            product.SKU = sku;
            product.Description = description;
            product.Length = len;
            product.Width = wid;
            product.Height = hgt;
            product.Weight = wgt;
            product.ClientId = clientId;

            _productRepo.Update(product);
        }

        public void Delete(int id)
        {
            _productRepo.Delete(id);
        }
    }
}