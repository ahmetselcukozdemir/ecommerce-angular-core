using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using eCommerceAPI.Application.Repositories.Product;

namespace eCommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async void Get()
        {
           await _productWriteRepository.AddRangeAsync(new()
            {
                new() {Id=Guid.NewGuid(),Name="Test",Price = 300,Stock = 10,CreatedDate = DateTime.Now,},
                 new() {Id=Guid.NewGuid(),Name="Test 2",Price = 350,Stock = 20,CreatedDate = DateTime.Now,}
            });

           await _productWriteRepository.SaveAsync();
        }
    }
}
