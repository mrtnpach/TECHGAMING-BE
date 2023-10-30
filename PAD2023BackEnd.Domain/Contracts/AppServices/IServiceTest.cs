using PAD2023BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD2023BackEnd.Domain.Contracts.AppServices
{
    public interface IServiceTest
    {
        Product GetProduct(int id);
    }
}
