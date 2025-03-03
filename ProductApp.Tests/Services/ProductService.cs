using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using UnitTestingAndMocking.Repositories;
using UnitTestingAndMocking.Services;
using Xunit;

public class ProductServiceTests
{
    [Fact]
    public void GetProductCount_ReturnsCorrectProductCount()
    {
        var mockRepo = new Mock<IProductRepository>();
        mockRepo.Setup(repo => repo.GetProductCount()).Returns(10);

        var productService = new ProductService(mockRepo.Object);

        var result = productService.GetProductCount();

        Assert.Equal(10, result);
    }
}
