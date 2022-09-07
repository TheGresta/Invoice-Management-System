using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Paging;
using Core.Utilities.Message;
using Core.Utilities.Result;
using InvoiceManagementSystem.Business.BusinessAspects;
using Microsoft.EntityFrameworkCore.Query;
using RezervationSystem.Business.Services.Abstract;
using RezervationSystem.Business.Validators.FluentValidation;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.Dto.Concrete;
using System.Linq.Expressions;

namespace RezervationSystem.Business.Services.Concrete
{
    public class UserManager : BaseManager<User, UserWriteDto, UserReadDto>, IUserService
    {
        public UserManager(IUserDal repository, ILanguageMessage languageMessage) : base(repository, languageMessage)
        {
        }

        [SecuretOperation("Admin")]
        [ValidationAspect(typeof(UserWriteDtoValidator))]
        public override async Task<DataResult<UserReadDto>> AddAsync(UserWriteDto writeDto)
        {
            return await base.AddAsync(writeDto);
        }

        [SecuretOperation("Admin")]
        [ValidationAspect(typeof(UserWriteDtoValidator))]
        public override async Task<DataResult<UserReadDto>> DeleteAsync(int id)
        {
            return await base.DeleteAsync(id);
        }

        [SecuretOperation("Admin")]
        [ValidationAspect(typeof(UserWriteDtoValidator))]
        public async override Task<DataResult<UserReadDto>> UpdateAsync(int id, UserWriteDto writeDto)
        {
            return await base.UpdateAsync(id, writeDto);
        }

        [SecuretOperation("Admin")]
        [ValidationAspect(typeof(UserWriteDtoValidator))]
        public override Task<DataResult<IPaginate<UserReadDto>>> GetListAsync(
            Expression<Func<User, bool>>? predicate = null,
            Func<IQueryable<User>, IOrderedQueryable<User>>? orderBy = null,
            Func<IQueryable<User>, IIncludableQueryable<User, object>>? include = null,
            int index = 0, int size = 10, bool enamleTracking = true,
            CancellationToken cancellationToken = default)
        {
            return base.GetListAsync(predicate, orderBy, include, index, size, enamleTracking, cancellationToken);
        }

        [SecuretOperation("Admin")]
        [ValidationAspect(typeof(UserWriteDtoValidator))]
        public override async Task<DataResult<UserReadDto>> GetByIdAsync(int id)
        {
            return await base.GetByIdAsync(id);
        }

    }
}
