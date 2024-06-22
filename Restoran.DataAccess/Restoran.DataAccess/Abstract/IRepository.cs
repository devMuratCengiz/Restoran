using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DataAccess.Abstract
{
    public interface IRepository<T>where T : class
    {
        List<T> GetAll();
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        T GetById(int id);
    }
}
