using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
  public class User
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int Password { get; set; }
    public int TC { get; set; }
    public string Plate { get; set; }
    public int PhoneNumber { get; set; }
    public bool IsAdmin { get; set; } = false;
    public string RefreshToken { get; set; }
    public DateTime? RefreshTokenExpireDate { get; set; }
  }
}