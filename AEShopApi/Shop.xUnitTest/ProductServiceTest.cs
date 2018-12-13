using Moq;
using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using Shop.Service.Interfaces;
using Shop.WebApi.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Shop.xUnitTest
{
    public class ProductServiceTest
    {
        public Mock<IProductRepository> _productRepositoryMock;
        public Mock<IUnitOfWork> _unitOfWorkMock;
        //public Mock<IProductService> _productServiceMock;
        //public ProductController _productController;

        public ProductServiceTest()
        {

        }

        #region Test1

        // [Fact]
        // public async Task TestAsync()
        // {
        //     _unitOfWorkMock = new Mock<IUnitOfWork>();
        //     _productRepositoryMock = new Mock<IProductRepository>();
        //     //_productServiceMock = new Mock<IProductService>();
        //     //_productController = new ProductController(_productServiceMock.Object);

        //     IEnumerable<Product> test = new List<Product>
        //     {
        //         new Product(){Id = 1,Name = "Test One",Detail = "Detail"},
        //         new Product(){Id = 2,Name = "Test Two",Detail = "Detail"}
        //     };

        //     //var a = _productRepositoryMock.Setup(x => x.GetAllAsync());
        //     //Assert.NotNull(a);
        //     //var result = _productController.GetProduct(1);
        // }

        #endregion Test1

        #region snippet_GetTestSessions

        private IEnumerable<Product> GetTestSessions()
        {
            var sessions = new List<Product>
            {
                new Product(){Id = 1,Name = "Test One",Detail = "Detail"},
                new Product(){Id = 2,Name = "Test Two",Detail = "Detail"}
            };
            return sessions.AsEnumerable();
        }

        #endregion snippet_GetTestSessions
    }
}