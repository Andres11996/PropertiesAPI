using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertiesAPI.Infrastructure
{
    public class Property
    {
        public int IdProperty { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public float Price { get; set; }
        public int CodeInternal { get; set; }
        public int Year { get; set; }
        public int IdOwner { get; set; }
    }
}
