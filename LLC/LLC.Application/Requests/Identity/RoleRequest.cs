using System.ComponentModel.DataAnnotations;

namespace LLC.Application.Requests.Identity
{
    public class RoleRequest
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}