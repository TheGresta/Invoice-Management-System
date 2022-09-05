using Core.DataAccess.EntityFramework;
using RezervationSystem.DataAccess.Abstract;
using RezervationSystem.DataAccess.Contexts;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.DataAccess.Concrete.EntityFramework
{
    public class EfApartmentDal : EfRepositoryBase<Apartment, InvoiceManagementSystemDbContext>, IApartmentDal
    {
        public EfApartmentDal(InvoiceManagementSystemDbContext context) : base(context)
        {
        }
    }
}