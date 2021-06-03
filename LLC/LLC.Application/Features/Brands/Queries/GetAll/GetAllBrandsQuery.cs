using AutoMapper;
using LLC.Application.Interfaces.Repositories;
using LLC.Domain.Entities.Catalog;
using LLC.Shared.Constants.Application;
using LLC.Shared.Wrapper;
using LazyCache;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LLC.Application.Features.Brands.Queries.GetAll
{
    public class GetAllBrandsQuery : IRequest<Result<List<GetAllBrandsResponse>>>
    {
        public GetAllBrandsQuery()
        {
        }
    }

    public class GetAllBrandsCachedQueryHandler : IRequestHandler<GetAllBrandsQuery, Result<List<GetAllBrandsResponse>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAppCache _cache;

        public GetAllBrandsCachedQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, IAppCache cache)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _cache = cache;
        }

        public async Task<Result<List<GetAllBrandsResponse>>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            Func<Task<List<Brand>>> getAllBrands = () => _unitOfWork.Repository<Brand>().GetAllAsync();
            var brandList = await _cache.GetOrAddAsync(ApplicationConstants.Cache.GetAllBrandsCacheKey, getAllBrands);
            var mappedBrands = _mapper.Map<List<GetAllBrandsResponse>>(brandList);
            return await Result<List<GetAllBrandsResponse>>.SuccessAsync(mappedBrands);
        }
    }
}