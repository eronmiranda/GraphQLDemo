using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotChocolate;

namespace GraphQLDemo.Models
{
  public class Platform
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }


    public string License { get; set; }

    public ICollection<Command> Commands { get; set; } = new List<Command>();
  }
}