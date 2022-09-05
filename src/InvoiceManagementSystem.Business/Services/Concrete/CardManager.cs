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
    public class CardManager : BaseManager<Card, CardWriteDto, CardReadDto>, ICardService
    {
        public CardManager(ICardDal repository, ILanguageMessage languageMessage) : base(repository, languageMessage)
        {
        }

        [ValidationAspect(typeof(CardWriteDtoValidator))]
        public override async Task<DataResult<CardReadDto>> AddAsync(CardWriteDto writeDto)
        {
            return await base.AddAsync(writeDto);
        }

        [ValidationAspect(typeof(CardWriteDtoValidator))]
        public async override Task<DataResult<CardReadDto>> UpdateAsync(int id, CardWriteDto writeDto)
        {
            return await base.UpdateAsync(id, writeDto);
        }
    }
}
