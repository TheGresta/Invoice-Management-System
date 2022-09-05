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
    public class MessageManager : BaseManager<Message, MessageWriteDto, MessageReadDto>, IMessageService
    {
        public MessageManager(IMessageDal repository, ILanguageMessage languageMessage) : base(repository, languageMessage)
        {
        }

        [ValidationAspect(typeof(MessageWriteDtoValidator))]
        public override async Task<DataResult<MessageReadDto>> AddAsync(MessageWriteDto writeDto)
        {
            return await base.AddAsync(writeDto);
        }

        [ValidationAspect(typeof(MessageWriteDtoValidator))]
        public async override Task<DataResult<MessageReadDto>> UpdateAsync(int id, MessageWriteDto writeDto)
        {
            return await base.UpdateAsync(id, writeDto);
        }
    }
}
