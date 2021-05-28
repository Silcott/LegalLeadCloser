using LLC.Application.Models.Chat;
using LLC.Application.Responses.Identity;
using LLC.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LLC.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}