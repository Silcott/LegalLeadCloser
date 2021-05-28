using LLC.Shared.Wrapper;
using System.Threading.Tasks;
using LLC.Application.Features.Dashboards.Queries.GetData;

namespace LLC.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}