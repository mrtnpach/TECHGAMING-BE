using PAD2023BackEnd.Domain.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD2023BackEnd.Domain.Entities
{
    public class Product : PersistentEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
