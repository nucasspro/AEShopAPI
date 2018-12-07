using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;

namespace Shop.Domain.Repositories.Implements
{
    public class DistrictRepository : Repository<District>, IDistrictRepository
    {
        public DistrictRepository(AeDbContext context) : base(context)
        {
        }
    }
}