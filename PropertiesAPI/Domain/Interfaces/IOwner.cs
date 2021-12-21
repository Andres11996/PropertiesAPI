using PropertiesAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertiesAPI.Domain.Interfaces
{
    public interface IOwner
    {
        List<Owner> Get();
        List<Owner> Get(int idIdOwner, string name);
        void Create(List<Owner> results);
        void Update(List<Owner> results);
        void Delete(int idOwner);
    }
}
