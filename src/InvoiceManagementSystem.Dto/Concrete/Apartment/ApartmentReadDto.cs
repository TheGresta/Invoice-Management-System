using Core.Dto;
using Core.Entities.Concrete;
using RezervationSystem.Entity.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace RezervationSystem.Dto.Concrete
{
    public class ApartmentReadDto : IReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BlockReadDto Block { get; set; }
        public bool IsEmpty { get; set; }
        public StyleReadDto Style { get; set; }
        public int Floor { get; set; }       
        public User Customer { get; set; }
    }
}
