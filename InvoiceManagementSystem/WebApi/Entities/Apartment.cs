using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
  public class Apartments
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int BlockID { get; set; }
    public Block Block { get; set; }
    public bool IsEmpty { get; set; } = true;
    public int StyleID { get; set; }
    public Style Style { get; set; }
    public int Floor { get; set; }
    public string CustomerName { get; set; }
    public int CustomerTC { get; set; }
    public string CustomerMail { get; set; }
    public int CustomerPhone { get; set; }
    public string CustomerPlate { get; set; }
    public int CustomerID { get; set; }
    public Customer Customer { get; set; }
  }
}