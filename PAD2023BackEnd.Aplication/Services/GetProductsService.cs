using PAD2023BackEnd.Domain.Contracts.AppServices;
using PAD2023BackEnd.Domain.Contracts.Repositories;
using PAD2023BackEnd.Domain.Entities;
using PAD2023BackEnd.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PAD2023BackEnd.Aplication.Services
{
    public class GetProductsService : IGetProductsService
    {
        private IRepository<Product> _productRepository;

        public GetProductsService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll().ToList();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.Get(id);
        }

        public List<Product> GetProductsByCategory(ProductCategory category)
        {
            return _productRepository.Get(p => p.ProductInfo.Category == category).ToList();
        }

        public List<Product> GetTop(int quantity)
        {
            // Buscar dentro de categoria
            // Ordenar por ranking
            // Seleccionar los primeros X
            throw new NotImplementedException();
        }

        public List<Product> GetTop(int quantity, ProductCategory category)
        {
            throw new NotImplementedException();
        }
    }
}