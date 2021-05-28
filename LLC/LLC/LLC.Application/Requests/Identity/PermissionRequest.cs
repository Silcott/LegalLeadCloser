using System.Collections.Generic;

namespace LLC.Application.Requests.Identity
{
    public class PermissionRequest
    {
        public string RoleId { get; set; }
        public IList<RoleClaimsRequest> RoleClaims { get; set; }
    }
}