using Core.Entities.Concrete;
using Core.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RezervationSystem.Entity.Concrete
{
    public class Apartment : BaseEntity
    {
        public string Name { get; set; }
        public int BlockID { get; set; }
        [ForeignKey("BlockID")]
        public Block Block { get; set; }
        public bool IsEmpty { get; set; } = true;
        public int StyleID { get; set; }
        [ForeignKey("StyleID")]
        public Style Style { get; set; }
        public int Floor { get; set; }
        public string CustomerName { get; set; }
        [ForeignKey("CustomerName")]
        public int CustomerTC { get; set; }
        [ForeignKey("CustomerTC")]
        public string CustomerMail { get; set; }
        [ForeignKey("CustomerMail")]
        public int CustomerPhone { get; set; }
        [ForeignKey("CustomerPhone")]
        public string CustomerPlate { get; set; }
        [ForeignKey("CustomerPlate")]
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public User Customer { get; set; }
    }
}
