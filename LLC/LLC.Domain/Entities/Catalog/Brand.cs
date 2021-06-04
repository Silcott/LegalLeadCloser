using LLC.Domain.Contracts;
using System;
using System.ComponentModel.DataAnnotations;

namespace LLC.Domain.Entities.Catalog
{
    public class Brand : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? CourtDate { get; set; }
        public string CourtLocation { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }

    }
}