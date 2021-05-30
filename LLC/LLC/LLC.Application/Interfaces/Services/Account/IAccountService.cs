using LLC.Application.Interfaces.Common;
using LLC.Application.Requests.Identity;
using LLC.Shared.Wrapper;
using System.Threading.Tasks;

namespace LLC.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);
        Task<IResult> DeleteUser(string userId);
        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}