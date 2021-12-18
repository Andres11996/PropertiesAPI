using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertiesAPI.Infrastructure
{
    public class Owner
    {
        public int IdOwner { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Photo { get; set; }
        public DateTime Birthday { get; set; }
    }
}
