using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MasterASP.Models
{
    [Table("employees")]
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Employee Id")]
        [Key, Column("employee_id")]
        public int EmployeeId { get; set; }

        [StringLength(15)]
        [Display(Name = "First Name")]
        [Column("first_name")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [Column("last_name")]
        [StringLength(15)]
        public string LastName { get; set; }

        [Display(Name = "Title")]
        [Column("title")]
        [StringLength(15)]
        public string Title { get; set; }

        [Display(Name = "Title Of Courtesy")]
        [Column("title_of_courtesy")]
        [StringLength(20)]
        public string TitleOfCourtesy { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "BirthDate")]
        [Column("birth_date")]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "HireDate")]
        [Column("hire_date")]
        public DateTime HireDate { get; set; }

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

        [Display(Name = "PostalCode")]
        [Column("postal_code")]
        public int PostalCode { get; set; }

        [Display(Name = "Country")]
        [Column("country")]
        [StringLength(20)]
        public string Country { get; set; }

        

        [Display(Name = "Extension")]
        [Column("extension")]
        [StringLength(20)]
        public string Extension { get; set; }

        

    }
}