using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
  public class Card
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string CardNumber { get; set; }
    public string CardPassword { get; set; }
    public int Balance { get; set; }  
  }
}