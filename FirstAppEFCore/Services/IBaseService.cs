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
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(object obj);
    }
}
