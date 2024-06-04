using Microsoft.AspNetCore.Mvc;
using TbiTestApi.Interfaces;
using TbiTestApi.Models;

namespace TbiTestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private readonly IProductRepository _productRepo;

    public ProductController(ILogger<ProductController> logger, IProductRepository productRepo)
    {
        _logger = logger;
        _productRepo = productRepo;
    }

    [HttpGet(Name = "GetProduct")]
    public async Task<IEnumerable<ProductModel>> GetProduct()
    {
        return await _productRepo.GetProducts();
    }
}

