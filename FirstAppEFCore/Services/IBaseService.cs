using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore.Services
{
    public interface IBaseService<TEntity> : IDisposable
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(object obj);
        Task<bool> AddAsync(TEntity entity);
        Task<bool> UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(object obj);
        Task<bool> AddRangeAsync(List<TEntity> entity);
    }
}
