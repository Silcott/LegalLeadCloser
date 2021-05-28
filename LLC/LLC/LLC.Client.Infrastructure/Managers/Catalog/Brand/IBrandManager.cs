using LLC.Application.Features.Brands.Queries.GetAll;
using LLC.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using LLC.Application.Features.Brands.Commands.AddEdit;

namespace LLC.Client.Infrastructure.Managers.Catalog.Brand
{
    public interface IBrandManager : IManager
    {
        Task<IResult<List<GetAllBrandsResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditBrandCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}