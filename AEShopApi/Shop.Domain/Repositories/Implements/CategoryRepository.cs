using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Shop.Domain.Repositories.Implements
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(AeDbContext context) : base(context)
        {
        }

        public async Task<Category> GetByName(string name)
        {
            using (IDbConnection conn = Connection)
            {
                var query = "SELECT * FROM Categories WHERE Name = @Name;";
                conn.Open();
                var result = await conn.QueryAsync<Category>(query, new { Name = name });
                return result.SingleOrDefault();
            }
        }
        public async Task<Category> GetMore(int id, string name)
        {
            using (IDbConnection conn = Connection)
            {
                var query = "SELECT * FROM Categories WHERE Id = @Id and Name = @Name;";
                conn.Open();
                var result = await conn.QueryAsync<Category>(query, new { Id = id, Name = name });
                return result.SingleOrDefault();
            }
        }
    }
}
