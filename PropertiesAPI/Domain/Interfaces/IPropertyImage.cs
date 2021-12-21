using PropertiesAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertiesAPI.Domain.Interfaces
{
    public interface IPropertyImage
    {
        List<PropertyImage> Get();
        List<PropertyImage> Get(int idPropertyImage, int idProperty);
        void Create(List<PropertyImage> results);
        void Update(List<PropertyImage> results);
        void Delete(int idPropertyImage);
    }
}
