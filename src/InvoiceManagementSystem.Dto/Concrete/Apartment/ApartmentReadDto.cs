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
        public string Blockname { get; set; }
        public Block Block { get; set; }
        public bool IsEmpty { get; set; }
        public string StyleName { get; set; }
        public Style Style { get; set; }
        public int Floor { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int CustomerTC { get; set; }
        public string CustomerMail { get; set; }
        public int CustomerPhone { get; set; }
        public string CustomerPlate { get; set; }        
        public User Customer { get; set; }
    }
}
