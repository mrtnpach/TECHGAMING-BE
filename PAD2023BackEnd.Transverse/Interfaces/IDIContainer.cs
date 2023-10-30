using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD2023BackEnd.Transverse.Interfaces
{
    public interface IDIContainer
    {
        T Create<T>();
        void RegisterType(Type type);
    }
}
