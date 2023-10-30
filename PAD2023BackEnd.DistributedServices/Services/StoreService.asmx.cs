using PAD2023BackEnd.Domain.Contracts.Repositories;
using PAD2023BackEnd.Domain.Entities;
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
            IRepository<Product> repository = 
                Factory.Instance.Container.Create<IRepository<Product>>();
            Product product = repository.Get(id);
            
            return product;
        }
    }
}
