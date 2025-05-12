using First_Simulation.Database.Models;

namespace First_Simulation.Database.ViewModels;

public class HomeViewModel
{
    public List<DoctorViewModel>? Doctors { get; set; }
    public List<RegisterViewModel>? Users { get; set; }
}
