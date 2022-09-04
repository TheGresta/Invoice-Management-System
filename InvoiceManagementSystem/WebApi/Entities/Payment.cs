using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
  public class Payment
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int CustomerID { get; set; }    
    public string CustomerName { get; set; }
    public User Customer { get; set; }
    public int ApartmentID { get; set; }
    public int Cost { get; set; }
    public DateTime Date { get; set; }
  }
}