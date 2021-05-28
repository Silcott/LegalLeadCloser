using LLC.Application.Extensions;
using LLC.Application.Interfaces.Repositories;
using LLC.Application.Specifications;
using LLC.Domain.Entities.Catalog;
using LLC.Shared.Wrapper;
using MediatR;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace LLC.Application.Features.Products.Queries.GetAllPaged
{
    public class GetAllProductsQuery : IRequest<PaginatedResult<GetAllPagedProductsResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SearchString { get; set; }

        public GetAllProductsQuery(int pageNumber, int pageSize, string searchString)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            SearchString = searchString;
        }
    }

    public class GGetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, PaginatedResult<GetAllPagedProductsResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GGetAllProductsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<PaginatedResult<GetAllPagedProductsResponse>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<Product, GetAllPagedProductsResponse>> expression = e => new GetAllPagedProductsResponse
            {
                Id = e.Id,
                Name = e.Name,
                Description = e.Description,
                Rate = e.Rate,
                Barcode = e.Barcode,
                Brand = e.Brand.Name,
                BrandId = e.BrandId
            };
            var productFilterSpec = new ProductFilterSpecification(request.SearchString);
            var data = await _unitOfWork.Repository<Product>().Entities
               .Specify(productFilterSpec)
               .Select(expression)
               .ToPaginatedListAsync(request.PageNumber, request.PageSize);
            return data;
        }
    }
}