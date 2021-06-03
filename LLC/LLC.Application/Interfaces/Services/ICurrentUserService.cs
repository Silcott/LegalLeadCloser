using LLC.Application.Interfaces.Common;

namespace LLC.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}