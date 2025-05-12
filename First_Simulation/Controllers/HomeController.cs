using First_Simulation.Database.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace First_Simulation.Controllers;


public class HomeController : Controller
{
    private readonly DoctorRepository _doctorRepository;

    public HomeController(DoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;
    }

    public IActionResult Index()
    {
        var doctors = _doctorRepository.GetAll();
        return View(doctors);
    }
}
