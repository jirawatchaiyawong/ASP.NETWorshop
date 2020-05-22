using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MasterASP.Models
{
    [Table("shippers")]
    public class Shipper
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Shipper Id")]
        [Column("shipper_id")]
        public int ShipperId { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "company name at least 2 charactor", MinimumLength = 2)]
        [Column("company_name")]
        public string CompanyName { get; set; }

        [StringLength(10)]
        [Column("phon")]
        public string Phon { get; set; }
    }
}