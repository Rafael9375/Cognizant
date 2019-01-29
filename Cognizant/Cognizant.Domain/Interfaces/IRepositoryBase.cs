using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T obj);
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Update(T obj);
        void Remove(T obj);
    }
}
