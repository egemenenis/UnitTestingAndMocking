using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingAndMocking.Repositories;

namespace ProductApp.Tests.Mocks
{
    public static class MockProductRepository
    {
        public static Mock<IProductRepository> CreateMockProductRepository()
        {
            var mockRepo = new Mock<IProductRepository>();
            mockRepo.Setup(repo => repo.GetProductCount()).Returns(10);
            return mockRepo;
        }
    }
}
