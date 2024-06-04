using System;
using System.ComponentModel.DataAnnotations.Schema;
using TbiTestApi.Models;

namespace TbiTestApi.Entities
{
    [Table("Stock", Schema = "dbo")]
    public class Stock
	{
        public long StockId { get; set; }
        public long ProductId { get; set; }
        public long Quantity { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }

        public Product Product { get; set; }
    }
}

