using PAD2023BackEnd.Domain.BaseEntities;
using PAD2023BackEnd.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD2023BackEnd.Domain.Entities
{
    public class Product : PersistentEntity
    {
        public ProductInfo ProductInfo { get; set; }
        public int Stock { get; set; }
    }
}