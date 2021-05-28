using System.ComponentModel.DataAnnotations;

namespace LLC.Application.Responses.Identity
{
    public class RoleResponse
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}