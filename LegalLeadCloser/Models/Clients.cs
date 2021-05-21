using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegalLeadCloser.Models
{
    public class Clients
    {
        public int ClientID { get; set; }
        public int UserID { get; set; }
        public string CourtName { get; set; }
        public string CourtCounty { get; set; }
        public string CourtDay { get; set; }
        public string CourtMonth { get; set; }
        public string CourtYear { get; set; }
        public string CourtTime { get; set; }
        public string StreetAddress { get; set; }
        public string CityAddress { get; set; }
        public string StateAddress { get; set; }
        public string ZipCodeAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ImageName { get; set; }
        public string CreationDate { get; set; }
        public string BirthDay { get; set; }
        public string BirthMonth { get; set; }
        public string BirthYear { get; set; }
        public string SecurityLevel { get; set; }
        public string Password { get; set; }
        public string LastLogin { get; set; }
    }
}
