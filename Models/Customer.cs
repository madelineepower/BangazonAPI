using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BangazonAPI.Models
{
  public class Customer
  {
    [Key]
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime AccountCreationDate { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public DateTime LastActiveDate { get; set; } // on every login reset the counter
    public bool Active { get; set; }

    public ICollection<Product> ProductsToSell; // to be sold
    public ICollection<Order> Orders; // to buy or have bought

  }
}