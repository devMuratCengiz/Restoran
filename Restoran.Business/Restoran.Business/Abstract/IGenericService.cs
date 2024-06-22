using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> TGetAll();
        void TCreate(T item);
        void TUpdate(T item);
        void TDelete(int id);
        T TGetById(int id);
    }
}
