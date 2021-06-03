using LLC.Application.Features.Documents.Commands.AddEdit;
using LLC.Application.Features.Documents.Queries.GetAll;
using LLC.Application.Requests.Documents;
using LLC.Shared.Wrapper;
using System.Threading.Tasks;

namespace LLC.Client.Infrastructure.Managers.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}