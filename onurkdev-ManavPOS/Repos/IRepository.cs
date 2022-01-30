using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onurkdev_ManavPOS.Repos
{
    public interface IRepository<T>
    {
        List<T> Get();
        T GetById(int id);

        int Create(T item);
        int Update(T item);
        int Delete(int id);
    }
}
