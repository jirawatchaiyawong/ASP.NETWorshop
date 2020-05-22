using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MasterASP.Models
{
    [Table("categories")]
    public class Category
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("category_id", Order = 0)]
        [Display(Name = "Category Id")]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "category name at least 2 charactor", MinimumLength = 2)]
        [Column("category_name")]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Description")]
        [StringLength(250, ErrorMessage = "description at least 2 charactor", MinimumLength = 2)]
        [Column("description")]
        public string Description { get; set; }
    }
}