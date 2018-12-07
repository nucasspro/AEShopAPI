using Dapper;
using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Domain.Repositories.Implements
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AeDbContext context) : base(context)
        {
        }

        #region Implements

        public bool CheckExistsById(int id)
        {
            return _context.Set<Product>().Any(x => x.Id == id);
        }

        public async Task<IEnumerable<Product>> GetByCategoryAsync(int categoryId, int pageSize, int getNumber)
        {
            string query = $@"SELECT Products.Name
                            FROM ProductCategories
	                             join Products on Products.Id = ProductCategories.ProductId
	                             join Categories on ProductCategories.CategoryId = Categories.Id
                            where Categories.Id = @CategoryId
                            ORDER BY Products.UpdatedAt
                            OFFSET @PageSize ROWS
                            FETCH NEXT @GetNumber ROWS ONLY;";
            IEnumerable<Product> data;
            using (var connection = new SqlConnection(_context.Database.GetDbConnection().ConnectionString))
            {
                data = await connection.QueryAsync<Product>(query, new { CategoryId = categoryId, PageSize = pageSize, GetNumber = getNumber });
            }
            return data;
        }

        public async Task<IEnumerable<Product>> GetProductsWithPaginationAsync(int PageSize, int GetNumber)
        {
            string query = $@"SELECT Products.*
                             FROM ProductCategories
	                            join Products on Products.Id = ProductCategories.ProductId
	                            join Categories on ProductCategories.CategoryId = Categories.Id
                             ORDER BY Products.UpdatedAt
                             OFFSET @PageSize ROWS
                             FETCH NEXT @GetNumber ROWS ONLY;";
            IEnumerable<Product> data;
            using (var connection = new SqlConnection(_context.Database.GetDbConnection().ConnectionString))
            {
                int OffSet = PageSize * GetNumber;
                data = await connection.QueryAsync<Product>(query, new { PageSize = OffSet, GetNumber});
            }
            return data;
        }

        #endregion Implements
    }
}