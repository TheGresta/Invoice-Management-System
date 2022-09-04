using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class User : BaseEntity
    {
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TC { get; set; }
        public string Plate { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}