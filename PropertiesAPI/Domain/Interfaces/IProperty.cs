using PropertiesAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertiesAPI.Domain.Interfaces
{
    public interface IProperty
    {
        List<Property> Get();
        List<Property> Get(int idProperty, string name);
        void Create(List<Property> results);
        void Update(List<Property> results);
        void Delete(int idProperty);
    }
}
