using LLC.Application.Responses.Audit;
using LLC.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LLC.Client.Infrastructure.Managers.Audit
{
    public interface IAuditManager : IManager
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync();

        Task<string> DownloadFileAsync();
    }
}