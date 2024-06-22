using Restoran.Business.Abstract;
using Restoran.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Business.Concrete
{
    public class GenericManager<T>(IRepository<T> _repository) : IGenericService<T> where T : class
    {

        public void TCreate(T item)
        {
            _repository.Create(item);
        }

        public void TDelete(int id)
        {
            _repository.Delete(id);
        }

        public List<T> TGetAll()
        {
            return _repository.GetAll();
            
        }

        public T TGetById(int id)
        {
            return _repository.GetById(id);
        }

        public void TUpdate(T item)
        {
            _repository.Update(item);
        }
    }
}
