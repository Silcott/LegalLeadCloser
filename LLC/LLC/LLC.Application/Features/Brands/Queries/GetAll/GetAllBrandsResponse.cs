using System;

namespace LLC.Application.Features.Brands.Queries.GetAll
{
    public class GetAllBrandsResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }//Name
        public string LastName { get; set; }//Description
        public DateTime CourtDate { get; set; }//Tax
        public string CourtLocation { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }



    }
}