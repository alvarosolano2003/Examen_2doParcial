using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class BaseRepository<T> : IModel<T>
    {
        protected List<T> data;
        public BaseRepository()
        {
            data = new List<T>();
        }

        public void Create(T t)
        {
            if (t == null)
            {
                throw new ArgumentException("El valor es nulo.");
            }

            data.Add(t);
        }

        public void Delete(T t)
        {
            if (t == null)
            {
                throw new ArgumentException("El valor es nulo.");
            }

            data.Remove(t);
        }

        public List<T> GetAll()
        {
            if (data == null)
            {
                throw new ArgumentException("No se han agregado valores.");
            }

            return data;
        }

        public List<T> GetBy(Predicate<T> predicate)
        {
            if (data.FindAll(predicate) == null)
            {
                throw new ArgumentException("No hay valores que cumplan la condicion.");
            }

            return data.FindAll(predicate);
        }

        public void Update(int index, T t)
        {
            if (t == null || index < 0)
            {
                throw new ArgumentException("El valor es nulo.");
            }

            data.Insert(index, t);
        }
    }
}
