using Microsoft.AspNetCore.Mvc;
using TbiTestApi.Interfaces;
using TbiTestApi.Models;

namespace TbiTestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CheckoutController : ControllerBase
{
    private readonly ILogger<CheckoutController> _logger;
    private readonly IProductRepository _productRepo;

    public CheckoutController(ILogger<CheckoutController> logger, IProductRepository productRepo)
    {
        _logger = logger;
        _productRepo = productRepo;
    }

    [HttpPost(Name = "Checkout")]
    public async Task<bool> Checkout(IEnumerable<CartModel> carts)
    {
        return await _productRepo.Checkout(carts);
    }
}

