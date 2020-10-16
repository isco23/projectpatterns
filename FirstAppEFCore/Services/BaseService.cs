using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly EFDemoContext _context;
        public BaseService(EFDemoContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> GetAll()
        {
            try
            {                
                return _context.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }            
        }

        public async Task<TEntity> GetById(object obj)
        {
            try
            {                
                return await _context.FindAsync<TEntity>(obj);                
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entity: {ex.Message}");
            }
        }

        public async Task<bool> AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }
            try
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        public async Task<bool> AddRangeAsync(List<TEntity> entity)
        {
            if (entity.Count == 0)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }
            try
            {
                await _context.AddRangeAsync(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        public async Task<bool> DeleteAsync(object obj)
        {
            var entity = await _context.Set<TEntity>().FindAsync(obj);
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(DeleteAsync)} entity must not be null");
            }
            try
            {
                _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be deleted: {ex.Message}");
            }
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
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
