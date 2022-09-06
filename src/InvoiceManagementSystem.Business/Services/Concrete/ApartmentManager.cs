using Core.Aspects.Autofac.Validation;
using Core.Paging;
using Core.Utilities.Message;
using Core.Utilities.Result;
using InvoiceManagementSystem.Business.BusinessAspects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using RezervationSystem.Business.Services.Abstract;
using RezervationSystem.Business.Validators.FluentValidation;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.Dto.Concrete;
using RezervationSystem.Entity.Concrete;
using System.Linq.Expressions;

namespace RezervationSystem.Business.Services.Concrete
{
    public class ApartmentManager : BaseManager<Apartment, ApartmentWriteDto, ApartmentReadDto>, IApartmentService
    {
        public ApartmentManager(IApartmentDal repository, ILanguageMessage languageMessage) : base(repository, languageMessage)
        {
        }

        //[SecuretOperation("Admin")]
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

        public override Task<DataResult<IPaginate<ApartmentReadDto>>> GetListAsync(
            Expression<Func<Apartment, bool>>? predicate = null, 
            Func<IQueryable<Apartment>, IOrderedQueryable<Apartment>>? orderBy = null, 
            Func<IQueryable<Apartment>, IIncludableQueryable<Apartment, object>>? include = null, 
            int index = 0, int size = 10, bool enamleTracking = true, 
            CancellationToken cancellationToken = default)
        {
            return base.GetListAsync(predicate, orderBy, (queryable) => {
                queryable = queryable.Include(a => a.Block).Include(a => a.Style);
                return (IIncludableQueryable<Apartment, object>)queryable;
            }, index, size, enamleTracking, cancellationToken);
        }
    }
}
