using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PAD2023BackEnd.DistributedServices.DependencyInjection;
using PAD2023BackEnd.Transverse.DependencyInjection;

namespace PAD2023BackEnd.DistributedServices.AppStart
{
    internal static class DIConfig
    {
        internal static void ConfigureContainer()
        {
            UnityContainer container = new UnityContainer();
            Factory.Instance.Container = container;
        }
    }
}