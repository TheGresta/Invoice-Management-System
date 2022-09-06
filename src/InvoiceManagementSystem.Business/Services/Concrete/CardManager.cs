using Core.Aspects.Autofac.Validation;
using Core.Utilities.Message;
using Core.Utilities.Result;
using Mapster;
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

        public async Task<DataResult<CardReadDto>> GetByCardNumberAsync(int cardNumber)
        {
            Card card = await Repository.GetAsync(x => x.CardNumber == cardNumber);

            if(card == null)
                return new ErrorDataResult<CardReadDto>("Wrong Card Number");

            CardReadDto cardReadDto = card.Adapt<CardReadDto>();

            return new SuccessDataResult<CardReadDto>(cardReadDto);
        }

        public async Task<IResult> UpdateCardPaymentByCardNumber(int cardNumber, int payment)
        {
            DataResult<CardReadDto> card = await GetByCardNumberAsync(cardNumber);

            card.Data.Balance -= payment;

            CardWriteDto cardWriteDto = card.Data.Adapt<CardWriteDto>();

            var result = await base.UpdateAsync(card.Data.Id, cardWriteDto);

            return result;
        }
    }
}
