using System;
namespace TbiTestApi.Models
{
	public class ProductModel
	{
        public long ProductId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public long Quantity { get; set; }
    }
}

