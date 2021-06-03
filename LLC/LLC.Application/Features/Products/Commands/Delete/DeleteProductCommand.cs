﻿using LLC.Application.Interfaces.Repositories;
using LLC.Domain.Entities.Catalog;
using LLC.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;

namespace LLC.Application.Features.Products.Commands.Delete
{
    public class DeleteProductCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
    }

    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Result<int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<DeleteProductCommandHandler> _localizer;

        public DeleteProductCommandHandler(IUnitOfWork unitOfWork, IStringLocalizer<DeleteProductCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.Repository<Product>().GetByIdAsync(command.Id);
            await _unitOfWork.Repository<Product>().DeleteAsync(product);
            await _unitOfWork.Commit(cancellationToken);
            return await Result<int>.SuccessAsync(product.Id, _localizer["Product Deleted"]);
        }
    }
}