using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MasterASP.Models
{
    [Table("customers")]
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Customer Id")]
        [Key, Column("customer_id")]
        public string CustomerId { get; set; }

        

        [Display(Name = "First Name")]
        [Column("first_name")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Column("last_name")]
        [StringLength(20)]
        public string LasttName { get; set; }

        

        [Required]
        [Display(Name = "Address")]
        [Column("address")]
        [StringLength(60)]
        public string Address { get; set; }

        [Display(Name = "City")]
        [Column("city")]
        [StringLength(20)]
        public string City { get; set; }

        [Display(Name = "Region")]
        [Column("region")]
        [StringLength(15)]
        public string Region { get; set; }

        [Display(Name = "Postal Code")]
        [Column("postal_code")]
        [StringLength(5)]
        public string PostalCode { get; set; }

        [Display(Name = "Country")]
        [Column("country")]
        [StringLength(20)]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Phon")]
        [Column("phon")]
        [StringLength(10)]
        public string Phon { get; set; }

        

        public virtual Collection<Order> Orders { get; set; }
        public int CountOrder => (Orders != null) ? Orders.Count() : 0;
    }
}