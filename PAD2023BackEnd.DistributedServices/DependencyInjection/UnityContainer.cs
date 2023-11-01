using PAD2023BackEnd.Aplication.Services;
using PAD2023BackEnd.Data.Repositories;
using PAD2023BackEnd.Domain.Contracts.AppServices;
using PAD2023BackEnd.Domain.Contracts.Repositories;
using PAD2023BackEnd.Domain.Entities;
using PAD2023BackEnd.Transverse.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Unity;
using Unity.Injection;

namespace PAD2023BackEnd.DistributedServices.DependencyInjection
{
    public class UnityContainer : IDIContainer
    {
        private IUnityContainer _unityContainer;

        public UnityContainer()
        {
            _unityContainer = new Unity.UnityContainer();
            ConfigureContainer();
        }

        public T Create<T>()
        {
            return _unityContainer.Resolve<T>();
        }

        public void RegisterType(Type type)
        {
            _unityContainer.RegisterType(type);
        }

        private void ConfigureContainer()
        {
            // Database definition
            //string connectionUri = "mongodb+srv://Agustin030s:G.N@6K#6R_nCiBS@cluster0.2a0uvlf.mongodb.net/?retryWrites=true&w=majority";
            var conexion = ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString;
            //string conectionString = ConfigurationManager.ConnectionStrings[""].ConnectionString;

            // Register definitions
            //_unityContainer.RegisterSingleton<IRepository<Product>, ProductoMockRepo>(new InjectionConstructor(conexion));
            _unityContainer.RegisterSingleton<IRepository<Product>, ProductMongoRepository>(new InjectionConstructor(conexion));
            _unityContainer.RegisterType<IServiceTest, ServiceTest>();
            _unityContainer.RegisterType<IGetProductsService, GetProductsService>();
        }
    }
}