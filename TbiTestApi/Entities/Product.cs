using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TbiTestApi.Entities
{
    [Table("Product", Schema = "dbo")]
    public class Product
	{
        public long ProductId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }

        public ICollection<Stock> Stocks { get; set; }
    }
}

