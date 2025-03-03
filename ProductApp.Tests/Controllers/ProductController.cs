using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingAndMocking.Controllers;
using UnitTestingAndMocking.Services;

namespace ProductApp.Tests.Controllers
{
    public class ProductControllerTests
    {
        [Fact]
        public void Index_ReturnsViewWithCorrectModel()
        {
            var mockService = new Mock<IProductService>();
            mockService.Setup(service => service.GetProductCount()).Returns(10);

            var controller = new ProductController(mockService.Object);

            var result = controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(10, viewResult.Model);
        }
    }
}
