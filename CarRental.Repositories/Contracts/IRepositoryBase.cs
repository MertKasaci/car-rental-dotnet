using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Contracts
{
    //Contract for base crud operations
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool isTraceable);
        IQueryable<T> FindByCondition(Expression<Func<T,bool>> expression ,bool isTraceable);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
