using UnitTestingAndMocking.Repositories;

namespace UnitTestingAndMocking.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public int GetProductCount()
        {
            return _productRepository.GetProductCount();
        }
    }
}
