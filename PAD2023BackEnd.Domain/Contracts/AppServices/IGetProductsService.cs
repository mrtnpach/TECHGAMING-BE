using PAD2023BackEnd.Domain.Entities;
using PAD2023BackEnd.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD2023BackEnd.Domain.Contracts.AppServices
{
    public interface IGetProductsService
    {
        Product GetProductById(int id);
        List<Product> GetProductsByCategory(ProductCategory category);
        List<Product> GetAllProducts();
        List<Product> GetTop(int quantity);
        List<Product> GetTop(int quantity, ProductCategory category);
    }
}
