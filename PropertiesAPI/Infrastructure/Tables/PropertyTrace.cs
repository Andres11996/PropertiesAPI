using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertiesAPI.Infrastructure
{
    public class PropertyTrace
    {
        public int IdPropertyTrace { get; set; }
        public DateTime DateSale { get; set; }
        public string Name { get; set; }
        public float Value { get; set; }
        public decimal Tax { get; set; }
        public int IdProperty { get; set; }
    }
}
