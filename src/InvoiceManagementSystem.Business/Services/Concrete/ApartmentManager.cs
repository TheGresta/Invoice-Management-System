using Core.Aspects.Autofac.Validation;
using Core.Utilities.Message;
using Core.Utilities.Result;
using RezervationSystem.Business.Services.Abstract;
using RezervationSystem.Business.Validators.FluentValidation;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.Dto.Concrete;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.Business.Services.Concrete
{
    public class ApartmentManager : BaseManager<Apartment, ApartmentWriteDto, ApartmentReadDto>, IApartmentService
    {
        public ApartmentManager(IApartmentDal repository, ILanguageMessage languageMessage) : base(repository, languageMessage)
        {
        }

        [ValidationAspect(typeof(ApartmentWriteDtoValidator))]
        public override async Task<DataResult<ApartmentReadDto>> AddAsync(ApartmentWriteDto writeDto)
        {
            return await base.AddAsync(writeDto);
        }

        [ValidationAspect(typeof(ApartmentWriteDtoValidator))]
        public async override Task<DataResult<ApartmentReadDto>> UpdateAsync(int id, ApartmentWriteDto writeDto)
        {
            return await base.UpdateAsync(id, writeDto);
        }
    }
}
