using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using SleekPrint.Areas.Customer.Controllers;
using SleekPrint.DataAccess.Repository.IRepository;
using SleekPrint.Models;

namespace SleekPrintTests.Controllers
{
    public class HomeControllerTests
    {
        private readonly Mock<ILogger<HomeController>> _mockLogger;
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly HomeController _homeController;

        public HomeControllerTests()
        {
            _mockLogger = new Mock<ILogger<HomeController>>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _homeController = new HomeController(_mockLogger.Object, _mockUnitOfWork.Object);
        }

        [Fact]
        public void Index_ReturnsViewResult_WithProductList()
        {
            // Arrange
            var productList = new List<Product>
                {
                    new Product { Id = 1, Title = "Product1" },
                    new Product { Id = 2, Title = "Product2" }
                };

            _mockUnitOfWork.Setup(uow => uow.Product.GetAll(
             It.IsAny<System.Linq.Expressions.Expression<System.Func<Product, bool>>>(),
                "Category,ProductImages"))
                .Returns(productList);

            // Act
            var result = _homeController.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Product>>(viewResult.Model);
            Assert.Equal(2, model.Count());
            _mockUnitOfWork.Verify(uow => uow.Product.GetAll(null, "Category,ProductImages"), Times.Once);
        }



    }
}
