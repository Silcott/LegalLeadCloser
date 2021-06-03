using LLC.Application.Interfaces.Common;
using LLC.Application.Requests.Identity;
using LLC.Application.Responses.Identity;
using LLC.Shared.Wrapper;
using System.Threading.Tasks;

namespace LLC.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}