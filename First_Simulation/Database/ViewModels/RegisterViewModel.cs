using System.ComponentModel.DataAnnotations;

namespace First_Simulation.Database.ViewModels
{
    public class RegisterViewModel
    {
        [MinLength(3)]
        public string Name { get; set; }
        [MinLength(3)]
        public string Surname { get; set; }
        [MinLength(3)]
        public string Username { get; set; }
        [DataType(DataType.EmailAddress), RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
        public string Email { get; set; }
        [DataType(DataType.Password), MinLength(6)]
        public string Password { get; set; }
        [DataType(DataType.Password), Compare("Password"), MinLength(6)]
        public string ConfirmPassword { get; set; }
    }
}
