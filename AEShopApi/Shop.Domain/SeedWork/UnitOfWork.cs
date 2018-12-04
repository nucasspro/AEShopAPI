using System.Threading.Tasks;

namespace Shop.Domain.SeedWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Variables

        private readonly AeDbContext _context;

        #endregion Variables

        #region Constructor

        public UnitOfWork(AeDbContext context)
        {
            _context = context;
        }

        #endregion Constructor

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