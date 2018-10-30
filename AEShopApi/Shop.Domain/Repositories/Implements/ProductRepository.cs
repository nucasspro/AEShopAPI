using Dapper;
using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Domain.Repositories.Implements
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AeDbContext context) : base(context)
        {
        }

        public async Task<Product> GetProductsByName(string name)
        {
            using (IDbConnection conn = Connection)
            {
                var query = "SELECT * FROM Products WHERE Products.Name = @Name;";
                conn.Open();
                var result = await conn.QueryAsync<Product>(query, new { Name = name });
                return result.SingleOrDefault();
            }
        }
    }
}