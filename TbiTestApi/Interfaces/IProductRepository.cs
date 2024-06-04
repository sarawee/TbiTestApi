using TbiTestApi.Models;
namespace TbiTestApi.Interfaces
{
	public interface IProductRepository
	{
		public Task<IEnumerable<ProductModel>> GetProducts();
		public Task<bool> Checkout(IEnumerable<CartModel> carts);
    }
}

