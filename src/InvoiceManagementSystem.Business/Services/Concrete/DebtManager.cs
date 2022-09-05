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
    public class DebtManager : BaseManager<Debt, DebtWriteDto, DebtReadDto>, IDebtService
    {
        public DebtManager(IDebtDal repository, ILanguageMessage languageMessage) : base(repository, languageMessage)
        {
        }

        [ValidationAspect(typeof(DebtWriteDtoValidator))]
        public override async Task<DataResult<DebtReadDto>> AddAsync(DebtWriteDto writeDto)
        {
            return await base.AddAsync(writeDto);
        }

        [ValidationAspect(typeof(DebtWriteDtoValidator))]
        public async override Task<DataResult<DebtReadDto>> UpdateAsync(int id, DebtWriteDto writeDto)
        {
            return await base.UpdateAsync(id, writeDto);
        }
    }
}
