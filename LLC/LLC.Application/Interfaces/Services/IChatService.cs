using LLC.Application.Models.Chat;
using LLC.Application.Responses.Identity;
using LLC.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LLC.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}