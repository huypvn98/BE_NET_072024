using DataAccess.NetCore.DBContext;
using DataAccess.NetCore.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        BE_072024dDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(BE_072024dDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<int> Delete(T entity)
        {
            _dbSet.Remove(entity);
            return 1;
        }

        public async Task<List<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        //public Task<List<T>> GetByFilter(string keyword)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<T?> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<int> Insert(T t)
        {
            await _dbSet.AddAsync(t);
            return 1;
        }

        public async Task<int> Update(T entity)
        {
            _dbSet.Update(entity);
            return 1;
        }
    }
}
