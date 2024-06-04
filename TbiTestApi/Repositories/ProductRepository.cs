using System;
using Microsoft.EntityFrameworkCore;
using TbiTestApi.Entities;
using TbiTestApi.Interfaces;
using TbiTestApi.Models;

namespace TbiTestApi.Repositories
{
	public class ProductRepository : IProductRepository
	{
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Checkout(IEnumerable<CartModel> carts)
        {
            foreach(var cart in carts)
            {
                await _context.Stocks.AddAsync(new Stock
                {
                    ProductId = cart.ProductId,
                    Quantity = -cart.CartQty
                });
            }
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<ProductModel>> GetProducts()
        {
            var query = _context.Products.Include(p => p.Stocks)
                .Select(p => new ProductModel
                {
                    ProductId = p.ProductId,
                    Name = p.Name,
                    Price = p.Price,
                    Quantity = p.Stocks.Sum(s => s.Quantity)
                });
            return await query.ToListAsync();
        }
    }
}

