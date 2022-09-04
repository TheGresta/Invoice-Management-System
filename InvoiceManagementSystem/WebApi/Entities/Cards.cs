using System;

namespace WebApi.Entities
{
  public class Cards
  {
    public int Id { get; set; }
    public string CardNumber { get; set; }
    public string CardPassword { get; set; }
    public int Balance { get; set; }  
  }
}