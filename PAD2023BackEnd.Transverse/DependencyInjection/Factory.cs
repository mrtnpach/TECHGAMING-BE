using PAD2023BackEnd.Transverse.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD2023BackEnd.Transverse.DependencyInjection
{
    public class Factory
    {
        private IDIContainer _container;
        private static volatile Factory _instance;
        private static readonly object _syncLock = new object();

        private Factory() { }

        public static Factory Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Factory();
                    }
                }
                return _instance;
            }
        }

        public IDIContainer Container
        {
            get
            {
                if (_container == null) 
                    throw new NullReferenceException("No container has been configured.");
                return _container;
            }
            set
            { 
                if(_container == null)
                    _container = value ?? throw new ArgumentException("Failed to configure container."); 
            }
        }
    }
}
