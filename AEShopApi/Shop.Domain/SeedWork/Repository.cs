using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Domain.SeedWork
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        #region Variables

        public readonly AeDbContext _context;

        #endregion Variables

        #region Constructor

        public Repository(AeDbContext context) => _context = context;

        #endregion Constructor

        #region Implements

        public async Task<IEnumerable<T>> GetAllAsync(string[] includes = null)
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task InsertAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }


        public async Task DeleteAsync(T entity)
        {
            var result = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == entity.Id);
            _context.Set<T>().Remove(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            _context.Set<T>().Remove(result);
        }

        

        #endregion Implements
    }
}