using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore.Services
{
    public interface IOtherBaseService<TEntity> : IDisposable
    {
        IQueryable<TEntity> Get();

        TEntity Get(int id);

        void Create(TEntity record);

        void Update(TEntity record);

        void Delete(int id);

        int Save();

        Task<int> SaveAsync();
    }
}
