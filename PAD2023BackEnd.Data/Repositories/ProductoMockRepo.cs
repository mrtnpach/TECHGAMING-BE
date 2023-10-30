using PAD2023BackEnd.Domain.Contracts.Repositories;
using PAD2023BackEnd.Domain.Entities;
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
            Product p1 = new Product() { Id = 1, Name = "Producto1", Price = 250.75M };
            Product p2 = new Product() { Id = 2, Name = "Producto2", Price = 500.00M };
            Product p3 = new Product() { Id = 3, Name = "Producto3", Price = 750.75M };
            Product p4 = new Product() { Id = 4, Name = "Producto4", Price = 840.50M };
            Product p5 = new Product() { Id = 5, Name = "Producto5", Price = 900.00M };
            _items.Add(p1);
            _items.Add(p2);
            _items.Add(p3);
            _items.Add(p4);
            _items.Add(p5);
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