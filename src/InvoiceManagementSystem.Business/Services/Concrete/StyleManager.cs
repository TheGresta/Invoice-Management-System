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
    public class StyleManager : BaseManager<Style, StyleWriteDto, StyleReadDto>, IStyleService
    {
        public StyleManager(IStyleDal repository, ILanguageMessage languageMessage) : base(repository, languageMessage)
        {
        }

        [ValidationAspect(typeof(StyleWriteDtoValidator))]
        public override async Task<DataResult<StyleReadDto>> AddAsync(StyleWriteDto writeDto)
        {
            return await base.AddAsync(writeDto);
        }

        [ValidationAspect(typeof(StyleWriteDtoValidator))]
        public async override Task<DataResult<StyleReadDto>> UpdateAsync(int id, StyleWriteDto writeDto)
        {
            return await base.UpdateAsync(id, writeDto);
        }
    }
}
