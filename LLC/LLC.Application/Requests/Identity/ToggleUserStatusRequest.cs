namespace LLC.Application.Requests.Identity
{
    public class ToggleUserStatusRequest
    {
        public bool ActivateUser { get; set; }
        public bool AutoConfirmEmail { get; set; }

        public string UserId { get; set; }
    }
}