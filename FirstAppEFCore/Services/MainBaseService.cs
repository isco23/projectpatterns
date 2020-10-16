using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore.Services
{
    public class MainBaseService<TEntity> where TEntity : class
    {
        private readonly EFDemoContext _context;
        public MainBaseService(EFDemoContext context)
        {
            _context = context;
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
                DisplayStates(_context.ChangeTracker.Entries());
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
                DisplayStates(_context.ChangeTracker.Entries());
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be deleted: {ex.Message}");
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

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }
            try
            {
                _context.Update(entity);
                DisplayStates(_context.ChangeTracker.Entries());
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }
        private static void DisplayStates(IEnumerable<EntityEntry> entries)
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"Entity: " + entry.Entity.GetType().Name + "State: " + entry.State.ToString());
            }
        }
    }
}
