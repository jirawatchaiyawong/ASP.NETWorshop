using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MasterASP.Models
{
    [Table("suppliers")]
    public class Supplier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Supplier Id")]
        [Key, Column("supplier_id", Order = 0)]
        public int SupplierId { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "company name at least 2 charactor", MinimumLength = 2)]
        [Column("company_name")]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [StringLength(20)]
        [Column("contact_name")]
        [Display(Name = "ContactName")]
        public string ContactName { get; set; }

        [StringLength(20)]
        [Display(Name = "Contact Title")]
        [Column("contact_title")]
        public string ContactTitle { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Address")]
        [Column("address")]
        public string Address { get; set; }

        [StringLength(20)]
        [Display(Name = "City")]
        [Column("city")]
        public string City { get; set; }

        [StringLength(15)]
        [Display(Name = "Region")]
        [Column("region")]
        public string Region { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        [Column("postal_code")]
        public int PostalCode { get; set; }

        [StringLength(20)]
        [Display(Name = "Country")]
        [Column("country")]
        public string Country { get; set; }

        [StringLength(10)]
        [Display(Name = "Phon")]
        [Column("phon")]
        public string Phon { get; set; }

        

       
    }
}