using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MasterASP.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("product_id", Order = 0)]
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }

        [Required]
        [StringLength(65, ErrorMessage = "product name at least 3 charactor", MinimumLength = 3)]
        [Column("product_name")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        

        [Column("category_id", Order = 2)]
        [Display(Name = "Category Id")]
        public int? CategoryId { get; set; }
        public Category category { get; set; }

        [Required]
        [Column("image_product")]
        [Display(Name = "Image Product")]
        public string ImageProduct { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }



        [Required]
        [Display(Name = "Unit Price")]
        [Column("unit_price")]
        public decimal UnitPrice { get; set; }

        [Required]
        [Display(Name = "Units In Stock")]
        [Column("units_in_stock")]
        public int UnitsInStock { get; set; }

        [Display(Name = "Units On Order")]
        [Column("units_on_order")]
        public int UnitsOnOrder { get; set; }

       

        [Display(Name = "Discontinued")]
        [Column("discontinued")]
        public int Discontinued { get; set; }
    }
}