using System.ComponentModel.DataAnnotations;

namespace Culturapp.Models.Requests
{
  public class CategoryRequest
  {
    public string? Name { get; set; }
    public string? Description { get; set; }
  }
}
