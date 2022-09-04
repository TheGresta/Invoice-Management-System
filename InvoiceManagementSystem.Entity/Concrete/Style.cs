using Core.Entities.Concrete;
using Core.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RezervationSystem.Entity.Concrete
{
    public class Style : BaseEntity
    {
        public string Name { get; set; }
    }
}