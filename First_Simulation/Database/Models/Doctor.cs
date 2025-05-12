using System.ComponentModel.DataAnnotations.Schema;

namespace First_Simulation.Database.Models;

public class Doctor : BaseEntity
{
    public string Name { get; set; }

    public string Surname { get; set; }

    public byte Age { get; set; }

    public string? ImageUrl { get; set; }
    [NotMapped]
    public IFormFile File { get; set; }
}
