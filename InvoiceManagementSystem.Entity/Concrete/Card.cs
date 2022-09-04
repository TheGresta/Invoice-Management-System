using Core.Entity;

namespace RezervationSystem.Entity.Concrete
{
    public class Card : BaseEntity
    {
        public int CardNumber { get; set; }
        public int CardPassword { get; set; }
        public int Balance { get; set; }
    }
}