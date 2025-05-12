using Microsoft.AspNetCore.Identity;

namespace First_Simulation.Database.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
