using PAD2023BackEnd.Domain.Contracts.Repositories;
using PAD2023BackEnd.Domain.Entities;
using PAD2023BackEnd.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PAD2023BackEnd.Data.Repositories
{
    public class ProductoMockRepo : IRepository<Product>
    {
        private List<Product> _items = new List<Product>();

        public ProductoMockRepo()
        {
            ProductInfo p1 = new ProductInfo() { Name = "Producto1", Price = 250.75M, Category = ProductCategory.Notebook };
            ProductInfo p2 = new ProductInfo() { Name = "Producto2", Price = 500.00M, Category = ProductCategory.BuiltPC };
            ProductInfo p3 = new ProductInfo() { Name = "Producto3", Price = 750.75M, Category = ProductCategory.Peripheral };
            ProductInfo p4 = new ProductInfo() { Name = "Producto4", Price = 840.50M, Category = ProductCategory.BuiltPC };
            ProductInfo p5 = new ProductInfo() { Name = "Producto5", Price = 900.00M, Category = ProductCategory.Components };
            _items.Add(new Product() { Id = 1, ProductInfo = p1, Stock = 499});
            _items.Add(new Product() { Id = 2, ProductInfo = p2, Stock = 499});
            _items.Add(new Product() { Id = 3, ProductInfo = p3, Stock = 499});
            _items.Add(new Product() { Id = 4, ProductInfo = p4, Stock = 499});
            _items.Add(new Product() { Id = 5, ProductInfo = p5, Stock = 499});
        }

        public void Delete(int id)
        {
            Product toDelete = _items.FirstOrDefault(x => x.Id == id);
            if (toDelete != null)
                _items.Remove(toDelete);
        }

        public Product Get(int id)
        {
            return _items.Where(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<Product> Get(Expression<Func<Product, bool>> filter)
        {
            return _items.Where(filter.Compile());
        }

        public IEnumerable<Product> GetAll()
        {
            return _items;
        }

        public void Modify(Product entity)
        {
            Product toModify = _items.FirstOrDefault(x => x.Id == entity.Id);
            if (toModify != null)
                toModify = entity;
        }
    }
}