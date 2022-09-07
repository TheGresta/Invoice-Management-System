using Core.Aspects.Autofac.Validation;
using Core.Paging;
using Core.Utilities.Message;
using Core.Utilities.Result;
using InvoiceManagementSystem.Business.BusinessAspects;
using Microsoft.EntityFrameworkCore.Query;
using RezervationSystem.Business.Services.Abstract;
using RezervationSystem.Business.Validators.FluentValidation;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.Dto.Concrete;
using RezervationSystem.Entity.Concrete;
using System.Linq.Expressions;

namespace RezervationSystem.Business.Services.Concrete
{
    public class BlockManager : BaseManager<Block, BlockWriteDto, BlockReadDto>, IBlockService
    {
        public BlockManager(IBlockDal repository, ILanguageMessage languageMessage) : base(repository, languageMessage)
        {
        }

        [SecuretOperation("Admin")]
        [ValidationAspect(typeof(BlockWriteDtoValidator))]
        public override async Task<DataResult<BlockReadDto>> AddAsync(BlockWriteDto writeDto)
        {
            return await base.AddAsync(writeDto);
        }

        [SecuretOperation("Admin")]
        [ValidationAspect(typeof(BlockWriteDtoValidator))]
        public async override Task<DataResult<BlockReadDto>> UpdateAsync(int id, BlockWriteDto writeDto)
        {
            return await base.UpdateAsync(id, writeDto);
        }

        [SecuretOperation("Admin")]
        public override async Task<DataResult<BlockReadDto>> DeleteAsync(int id)
        {
            return await base.DeleteAsync(id);
        }

        [SecuretOperation("Admin")]
        public override async Task<DataResult<BlockReadDto>> GetByIdAsync(int id)
        {
            return await base.GetByIdAsync(id);
        }

        [SecuretOperation("Admin")]
        public override async Task<DataResult<IPaginate<BlockReadDto>>> GetListAsync(
            Expression<Func<Block, bool>>? predicate = null, 
            Func<IQueryable<Block>, IOrderedQueryable<Block>>? orderBy = null, 
            Func<IQueryable<Block>, IIncludableQueryable<Block, object>>? 
            include = null, int index = 0, int size = 10, bool enamleTracking = true, 
            CancellationToken cancellationToken = default)
        {
            return await base.GetListAsync(predicate, orderBy, include, index, size, enamleTracking, cancellationToken);
        }
    }
}
