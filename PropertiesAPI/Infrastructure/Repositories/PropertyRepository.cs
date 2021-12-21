using PropertiesAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertiesAPI.Infrastructure.Repositories
{
    public class PropertyRepository : IProperty
    {
        public PropertyRepository()
        {
        }

        public void Create(List<Property> results)
        {
            throw new NotImplementedException();
        }

        public void Delete(int idProperty)
        {
            throw new NotImplementedException();
        }

        public List<Property> Get()
        {
            throw new NotImplementedException();
        }

        public List<Property> Get(int idProperty, string name)
        {
            throw new NotImplementedException();
        }

        public void Update(List<Property> results)
        {
            throw new NotImplementedException();
        }
    }
}
