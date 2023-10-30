using PAD2023BackEnd.Domain.Contracts.AppServices;
using PAD2023BackEnd.Domain.Contracts.Repositories;
using PAD2023BackEnd.Domain.Entities;
using PAD2023BackEnd.Domain.Enumerations;
using PAD2023BackEnd.Transverse.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Description;

namespace PAD2023BackEnd.DistributedServices.Services
{
    /// <summary>
    /// Summary description for StoreService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class StoreService : System.Web.Services.WebService
    {
        [WebMethod]
        public Product GetProductById(int id)
        {
            // Idealmente la inyeccion estaria hecha por constructor,
            // pero no se el funcionamiento interno de esto je
            // Por lo menos sirve para pruebas
            IGetProductsService service =
                Factory.Instance.Container.Create<IGetProductsService>();

            return service.GetProductById(id);
        }

        [WebMethod]
        public List<Product> GetProductsByCategory(ProductCategory category)
        {
            IGetProductsService service =
                Factory.Instance.Container.Create<IGetProductsService>();

            return service.GetProductsByCategory(category);
        }

        [WebMethod]
        public List<Product> GetAllProducts()
        {
            IGetProductsService service =
                Factory.Instance.Container.Create<IGetProductsService>();

            return service.GetAllProducts();
        }
    }
}