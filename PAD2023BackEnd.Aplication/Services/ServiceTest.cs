using PAD2023BackEnd.Domain.Contracts.AppServices;
using PAD2023BackEnd.Domain.Contracts.Repositories;
using PAD2023BackEnd.Domain.Entities;

namespace PAD2023BackEnd.Aplication.Services
{
    public class ServiceTest : IServiceTest
    {
        private IRepository<Product> _productRepository;

        public ServiceTest(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetProduct(int id)
        {
            return _productRepository.Get(id);
        }
    }
}