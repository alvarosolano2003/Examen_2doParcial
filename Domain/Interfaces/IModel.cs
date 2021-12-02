using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IModel<T>
    {
        void Create(T t);
        List<T> GetAll();
        void Update(int index, T t);
        void Delete(T t);
        List<T> GetBy(Predicate<T> predicate);
    }
}
