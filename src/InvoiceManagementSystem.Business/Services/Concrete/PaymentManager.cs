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
    public class PaymentManager : BaseManager<Payment, PaymentWriteDto, PaymentReadDto>, IPaymentService
    {
        public PaymentManager(IPaymentDal repository, ILanguageMessage languageMessage) : base(repository, languageMessage)
        {
        }

        [ValidationAspect(typeof(PaymentWriteDtoValidator))]
        public override async Task<DataResult<PaymentReadDto>> AddAsync(PaymentWriteDto writeDto)
        {
            return await base.AddAsync(writeDto);
        }

        [ValidationAspect(typeof(PaymentWriteDtoValidator))]
        public async override Task<DataResult<PaymentReadDto>> UpdateAsync(int id, PaymentWriteDto writeDto)
        {
            return await base.UpdateAsync(id, writeDto);
        }
    }
}
