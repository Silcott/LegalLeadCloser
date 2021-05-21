using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LegalLeadCloser.Models
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        public string CompanyName { get; set; }
        public string YearsPracticing { get; set; }
        public string MonthsPracticing { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string StreetAddress { get; set; }
        public string CityAddress { get; set; }
        public string StateAddress { get; set; }
        public string ZipCodeAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ImageName { get; set; }
        public string CreationDate { get; set; }
        public string SubscriptionSerivice { get; set; }
        public string SecurityLevel { get; set; }
        public string Password { get; set; }
        public string LastLogin { get; set; }

    }
}
