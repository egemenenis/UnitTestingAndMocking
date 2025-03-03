namespace UnitTestingAndMocking.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public int GetProductCount()
        {
            return 10;
        }
    }
}
