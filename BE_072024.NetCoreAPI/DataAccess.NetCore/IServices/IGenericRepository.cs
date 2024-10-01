using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.IServices
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<int> Insert(T t);
        Task<int> Update(T t);
        Task<int> Delete(T t);
        Task<T> GetById(int id);
        //Task<List<T>> GetByFilter(string keyword);

    }
}
