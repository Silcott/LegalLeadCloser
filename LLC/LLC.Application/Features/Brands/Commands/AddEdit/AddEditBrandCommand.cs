using System.ComponentModel.DataAnnotations;
using AutoMapper;
using LLC.Application.Interfaces.Repositories;
using LLC.Domain.Entities.Catalog;
using LLC.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using LLC.Shared.Constants.Application;
using System;

namespace LLC.Application.Features.Brands.Commands.AddEdit
{
    public partial class AddEditBrandCommand : IRequest<Result<int>>
    {
        //TODO set realtionship with user and client ID
        public int Id { get; set; }

        public string CreatedBy { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? CourtDate { get; set; }

        public string CourtLocation { get; set; }
        //[Display(Name = "Phone")]
        //[DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\\(?(\[0-9\]{3})\\)?\[-.●\]?(\[0-9\]{3})\[-.●\]?(\[0-9\]{4})$", ErrorMessage = "The PhoneNumber field is not a valid phone number")]
        //[Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
    }

    public class AddEditBrandCommandHandler : IRequestHandler<AddEditBrandCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<AddEditBrandCommandHandler> _localizer;
        private readonly IUnitOfWork _unitOfWork;

        public AddEditBrandCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IStringLocalizer<AddEditBrandCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(AddEditBrandCommand command, CancellationToken cancellationToken)
        {
            if (command.Id == 0)
            {
                var brand = _mapper.Map<Brand>(command);
                await _unitOfWork.Repository<Brand>().AddAsync(brand);
                await _unitOfWork.ComitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllBrandsCacheKey);
                return await Result<int>.SuccessAsync(brand.Id, _localizer["Client Saved"]);
            }
            else
            {
                var brand = await _unitOfWork.Repository<Brand>().GetByIdAsync(command.Id);
                if (brand != null)
                {
                    //TODO fix dates - birth and court dates
                    brand.FirstName = command.FirstName ?? brand.FirstName;
                    brand.LastName = command.LastName ?? brand.LastName;
                    brand.CourtDate = brand.CourtDate;
                    brand.CourtLocation = command.CourtLocation ?? brand.CourtLocation;
                    brand.Phone = command.Phone ?? brand.Phone;
                    brand.Email = command.Email ?? brand.Email;
                    brand.Birthdate = brand.Birthdate;
                    brand.CreatedBy = command.CreatedBy;


                    //brand.LastName = (command.Tax == 0) ? brand.Tax : command.Tax;
                    await _unitOfWork.Repository<Brand>().UpdateAsync(brand);
                    await _unitOfWork.ComitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllBrandsCacheKey);
                    return await Result<int>.SuccessAsync(brand.Id, _localizer["CLient Updated"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Client Not Found!"]);
                }
            }
        }
    }
}