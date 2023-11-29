using PAD2023BackEnd.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD2023BackEnd.Domain.Entities
{
    public class ProductInfo
    {
        public string Name { get; set; }
        public ProductCategory Category { get; set; }
        public decimal Price { get; set; }
        public short Rating { get; set; }
        public Brand Brand { get; set; }
        public string Description { get; set; }
        public List<string> Specifications { get; set; }
        public string ShortDescription { get; set; }
        public string MainImageURL { get; set; }
        public List<string> ImageURLs { get; set; }
    }
}