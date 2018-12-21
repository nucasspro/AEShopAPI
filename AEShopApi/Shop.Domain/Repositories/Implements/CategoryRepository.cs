using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Shop.Domain.Enumerations;

namespace Shop.Domain.Repositories.Implements
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(AeDbContext context) : base(context)
        {
        }

        #region Implements

        public bool CheckExistsById(int id)
        {
            return _context.Set<Category>().Any(x => x.Id == id);
        }

        public async Task<bool> Delete(int id)
        {
            using (IDbConnection connection = new SqlConnection(_context.Database.GetDbConnection().ConnectionString))
            {

                var query = @"UPDATE Categories SET CategoryStatusTypeId = @CATEGORYSTATUSTYPEID WHERE id = @ID";
                await connection.ExecuteAsync(query, new { ID = id, CATEGORYSTATUSTYPEID = CategoryStatusTypeEnum.Removed.Id });
                return true;
            }
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            string query = @"SELECT * FROM Categories WHERE CategoryStatusTypeId = @CATEGORYSTATUSTYPEID";
            using (var connection = new SqlConnection(_context.Database.GetDbConnection().ConnectionString))
            {
                return await connection.QueryAsync<Category>(query, new { CATEGORYSTATUSTYPEID = CategoryStatusTypeEnum.Actived.Id });
            }
        }

        public async Task<IEnumerable<CategoryStatusType>> GetCategoryStatusTypes()
        {
            var query = "SELECT * FROM CategoryStatusTypes";

            using (var connection = new SqlConnection(_context.Database.GetDbConnection().ConnectionString))
            {
                return await connection.QueryAsync<CategoryStatusType>(query);
            }
        }

        #endregion Implements
    }
}