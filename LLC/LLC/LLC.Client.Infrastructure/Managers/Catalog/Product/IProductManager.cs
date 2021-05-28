using LLC.Application.Features.Products.Commands.AddEdit;
using LLC.Application.Features.Products.Queries.GetAllPaged;
using LLC.Application.Requests.Catalog;
using LLC.Shared.Wrapper;
using System.Threading.Tasks;

namespace LLC.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<string> ExportToExcelAsync();
    }
}