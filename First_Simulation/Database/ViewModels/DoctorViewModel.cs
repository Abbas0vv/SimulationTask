using First_Simulation.Database.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace First_Simulation.Database.ViewModels
{
    public class DoctorViewModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public byte Age { get; set; }

        [NotMapped]
        public IFormFile? File { get; set; }
    }
}
