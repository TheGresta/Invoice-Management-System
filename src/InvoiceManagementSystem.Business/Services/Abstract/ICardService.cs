using RezervationSystem.Dto.Concrete;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.Business.Services.Abstract
{
    public interface ICardService : IBaseService<Card, CardWriteDto, CardReadDto>
    {
    }
}