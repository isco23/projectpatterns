using EFCoreApi.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore.Services
{
    public class OtherBaseService<T> : IOtherBaseService<T> where T : class
    {
        private readonly EFDemoContext _context;
        public OtherBaseService(EFDemoContext context)
        {
            _context = context;
        }
        public IQueryable<T> Get()
        {
            return _context.Set<T>();
        }

        public T Get(int id)
        {
            return _context.Find<T>(id);
        }

        public void Create(T record)
        {            
            _context.Add(record);
        }

        public void Update(T record)
        {            
            _context.Set<T>().Attach(record);         
        }

        public void Delete(int id)
        {
            var record = Get(id);

            if (record != null)
            {
            }
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();                    
                }
            }
        }
    }
}
