using System.Collections;
using System.Threading.Tasks;

namespace Shop.Domain.SeedWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Variables

        private readonly AeDbContext _context;
        private Hashtable repositories = new Hashtable();

        #endregion Variables

        #region Constructor

        public UnitOfWork(AeDbContext context)
        {
            _context = context;
        }

        #endregion Constructor

        #region Methods

        public IRepository<T> GetRepository<T>() where T : Entity
        {
            if (!repositories.Contains(typeof(T)))
            {
                repositories.Add(typeof(T), new Repository<T>(_context));
            }
            return (IRepository<T>)repositories[typeof(T)];
        }

        #endregion Methods

        #region Implements

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        #endregion Implements
    }
}