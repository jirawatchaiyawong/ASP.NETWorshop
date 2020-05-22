using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MasterASP.Models
{

    [Table("orders")]
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Order Id")]
        [Key, Column("order_id", Order = 0)]
        public int OrderId { get; set; }

        [Display(Name = "Product Id")]
        [Column("product_id", Order = 1)]
        public string ProductId { get; set; }
        public Product product { get; set; }

      

       

        [Required]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
         = new HashSet<OrderDetail>();
        //anonymus function
        public decimal SubTotal => OrderDetails.Sum(x => x.Total);
        public decimal VatAmount => Math.Round(SubTotal * 0.07m, 2, MidpointRounding.AwayFromZero);
        public decimal NetTotal => SubTotal + VatAmount;

    }
}