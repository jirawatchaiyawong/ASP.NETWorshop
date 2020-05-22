using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MasterASP.Models
{
    [Table("cart")]
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("cart_id", Order = 0)]
        [Display(Name = "Cart Id")]
        public int CartId { get; set; }

        [Column("product_id", Order = 2)]
        [Display(Name = "Product Id")]
        public int? ProductId { get; set; }
        public Product product { get; set; }

        [Required]
        [StringLength(65, ErrorMessage = "product name at least 3 charactor", MinimumLength = 3)]
        [Column("product_name")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }


        [Required]
        [Display(Name = "Unit Price")]
        [Column("unit_price")]
        public decimal UnitPrice { get; set; }


        [Display(Name = "Discontinued")]
        [Column("discontinued")]
        public int Discontinued { get; set; }

    }
}