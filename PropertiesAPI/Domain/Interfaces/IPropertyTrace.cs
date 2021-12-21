using PropertiesAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertiesAPI.Domain.Interfaces
{
    public interface IPropertyTrace
    {
        List<PropertyTrace> Get();
        List<PropertyTrace> Get(int idPropertyTrace, int idProperty);
        void Create(List<PropertyTrace> results);
        void Update(List<PropertyTrace> results);
        void Delete(int idPropertyTrace);
    }
}
