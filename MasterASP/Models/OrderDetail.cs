using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MasterASP.Models
{
    [Table("order_details")]
    public class OrderDetail
    {
        [Key, Column("order_id", Order = 0)]
        public int? OrderId { get; set; }
        public Order order { get; set; }

        [Key, Column("product_id", Order = 1)]
        public int? ProductId { get; set; }
        public Product product { get; set; }

        [Column("unit_price")]
        public decimal UnitPrice { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("discount")]
        public int Discount { get; set; }

        public decimal Total => (decimal)Quantity * UnitPrice;
    }
}