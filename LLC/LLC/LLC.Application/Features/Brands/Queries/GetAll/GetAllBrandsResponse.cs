using System;

namespace LLC.Application.Features.Brands.Queries.GetAll
{
    public class GetAllBrandsResponse
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CourtDate { get; set; }
        public string CourtLocation { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }



    }
}