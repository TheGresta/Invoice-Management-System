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
    public class BlockManager : BaseManager<Block, BlockWriteDto, BlockReadDto>, IBlockService
    {
        public BlockManager(IBlockDal repository, ILanguageMessage languageMessage) : base(repository, languageMessage)
        {
        }

        [ValidationAspect(typeof(BlockWriteDtoValidator))]
        public override async Task<DataResult<BlockReadDto>> AddAsync(BlockWriteDto writeDto)
        {
            return await base.AddAsync(writeDto);
        }

        [ValidationAspect(typeof(BlockWriteDtoValidator))]
        public async override Task<DataResult<BlockReadDto>> UpdateAsync(int id, BlockWriteDto writeDto)
        {
            return await base.UpdateAsync(id, writeDto);
        }
    }
}
