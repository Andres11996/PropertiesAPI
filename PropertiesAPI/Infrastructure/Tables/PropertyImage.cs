using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertiesAPI.Infrastructure
{
    public class PropertyImage
    {
        public int IdPropertyImage { get; set; }
        public int IdProperty { get; set; }
        public int File { get; set; }
        public bool Enabled { get; set; }
    }
}
