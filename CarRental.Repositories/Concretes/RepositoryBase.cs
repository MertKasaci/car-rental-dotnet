using CarRental.Entities.Models;
using CarRental.Repositories.Contracts;
using CarRental.Repositories.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Repositories.Concretes
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : Entity
    {
        protected readonly CarRentalContext _context;

        public RepositoryBase(CarRentalContext context)
        {
            _context = context;
        }

        public void Create(T entity) =>
            _context.Set<T>().Add(entity);
        

        public void Delete(T entity) =>
            _context.Set<T>().Remove(entity);


        public IQueryable<T> FindAll(bool isTraceable) =>
            isTraceable ?
            _context.Set<T>() :
            _context.Set<T>().AsNoTracking();
        

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool isTraceable) =>
            isTraceable ?
            _context.Set<T>().Where(expression) :
            _context.Set<T>().Where(expression).AsNoTracking();


        public void Update(T entity) =>
            _context.Set<T>().Update(entity);
        
    }
}
