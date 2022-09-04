using Core.Entities.Concrete;
using Core.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RezervationSystem.Entity.Concrete
{
    public class Message : BaseEntity
    {
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public string CustomerName { get; set; }
        [ForeignKey("CustomerName")]
        public User Customer { get; set; }
        public string WrotenMessage { get; set; }
    }
}