using LLC.Application.Responses.Audit;
using LLC.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LLC.Application.Interfaces.Services
{
    public interface IAuditService
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync(string userId);

        Task<string> ExportToExcelAsync(string userId);
    }
}