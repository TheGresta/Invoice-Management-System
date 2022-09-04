using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
  public class Message
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int CustomerID { get; set; }
    public int CustomerName { get; set; }
    public User Customer { get; set; }
    public string WrotenMessage { get; set; }
    public DateTime Date { get; set; }
  }
}