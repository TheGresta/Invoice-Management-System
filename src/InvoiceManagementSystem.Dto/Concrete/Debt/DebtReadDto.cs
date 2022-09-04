using Core.Dto;
using Core.Entities.Concrete;
using RezervationSystem.Entity.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace RezervationSystem.Dto.Concrete
{
    public class DebtReadDto : IReadDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public User Customer { get; set; }
        public int ApartmentName { get; set; }
        public Apartment Apartment { get; set; }
        public int Cost { get; set; }
    }
}
