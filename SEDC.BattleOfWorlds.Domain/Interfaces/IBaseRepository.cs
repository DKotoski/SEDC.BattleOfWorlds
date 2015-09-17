
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.BattleOfWorlds.Domain.Interfaces
{
    public interface IBaseRepository<T>
    {
        ICollection<T> GetAll();
        void Add(T entity);
        T Get(int id);
        void Delete(int id);
        void Delete(T entity);
    }
}
