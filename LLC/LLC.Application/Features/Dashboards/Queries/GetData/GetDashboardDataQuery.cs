﻿using LLC.Application.Interfaces.Repositories;
using LLC.Application.Interfaces.Services.Identity;
using LLC.Domain.Entities.Catalog;
using LLC.Shared.Wrapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;

namespace LLC.Application.Features.Dashboards.Queries.GetData
{
    public class GetDashboardDataQuery : IRequest<Result<DashboardDataResponse>>
    {
        
    }

    public class GetDashboardDataQueryHandler : IRequestHandler<GetDashboardDataQuery, Result<DashboardDataResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IStringLocalizer<GetDashboardDataQueryHandler> _localizer;

        public GetDashboardDataQueryHandler(IUnitOfWork unitOfWork, IUserService userService, IRoleService roleService, IStringLocalizer<GetDashboardDataQueryHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _userService = userService;
            _roleService = roleService;
            _localizer = localizer;
        }

        public async Task<Result<DashboardDataResponse>> Handle(GetDashboardDataQuery query, CancellationToken cancellationToken)
        {
            var response = new DashboardDataResponse
            {
                ProductCount = await _unitOfWork.Repository<Product>().Entities.CountAsync(cancellationToken),
                BrandCount = await _unitOfWork.Repository<Brand>().Entities.CountAsync(cancellationToken),
                //usercount2 is used to find the number of users by DateCreated for the graph
                UserCount2 = await _unitOfWork.Repository2<Models.Identity.LLCUser>().Entities.CountAsync(cancellationToken),
                UserCount = await _userService.GetCountAsync(),
                RoleCount = await _roleService.GetCountAsync()
            };


            var selectedYear = DateTime.Now.Year;
            double[] productsFigure = new double[13];
            double[] brandsFigure = new double[13];
            double[] usersFigure = new double[13];
            for (int i = 1; i <= 12; i++)
            {
                var month = i;
                var filterStartDate = new DateTime(selectedYear, month, 01);
                var filterEndDate = new DateTime(selectedYear, month, DateTime.DaysInMonth(selectedYear, month), 23, 59, 59); // Monthly Based

                //productsFigure[i - 1] = await _unitOfWork.Repository<Product>().Entities.Where(x => x.CreatedOn >= filterStartDate && x.CreatedOn <= filterEndDate).CountAsync(cancellationToken);
                brandsFigure[i - 1] = await _unitOfWork.Repository<Brand>().Entities.Where(x => x.CreatedOn >= filterStartDate && x.CreatedOn <= filterEndDate).CountAsync(cancellationToken);
                usersFigure[i - 1] = await _unitOfWork.Repository2<Models.Identity.LLCUser>().Entities.Where(x => x.CreatedOn >= filterStartDate && x.CreatedOn <= filterEndDate).CountAsync(cancellationToken);

            }

            //response.DataEnterBarChart.Add(new ChartSeries { Name = _localizer["Products"], Data = productsFigure });
            response.DataEnterBarChart.Add(new ChartSeries { Name = _localizer["Clients"], Data = brandsFigure });
            response.DataEnterBarChart.Add(new ChartSeries { Name = _localizer["Users"], Data = usersFigure });

            return await Result<DashboardDataResponse>.SuccessAsync(response);
        }
    }
}