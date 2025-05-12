using First_Simulation.Database.Models;
using First_Simulation.Database.Repositories;
using First_Simulation.Database.ViewModels;
using First_Simulation.Helpers.Extentions;
using Microsoft.AspNetCore.Mvc;
namespace First_Simulation.Areas.Admin.Controllers;

[Area("Admin")]
public class AdminDashboardController : Controller
{

    private readonly DoctorRepository _doctorRepository;
    private readonly IWebHostEnvironment _webHostEnvironment;

    public AdminDashboardController(IWebHostEnvironment webHostEnvironment,DoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;
        _webHostEnvironment = webHostEnvironment;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var doctors = _doctorRepository.GetAll();
        return View(doctors);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(DoctorViewModel doctor)
    {
        if (!ModelState.IsValid) return View(doctor);
        if (!doctor.File.ContentType.Contains("image"))
        {
            ModelState.AddModelError("File", "Enter an image");
            return View(doctor);
        }
        if (doctor.File.Length > 2000000)
        {
            ModelState.AddModelError("File", "Enter an image which is smaller than 2mb");
            return View(doctor);
        }
        var imgUrl = doctor.File.CreateFile(_webHostEnvironment.WebRootPath, "upload/doctor");

        Doctor myDoctor = new Doctor
        {
            Name = doctor.Name,
            Age = doctor.Age,
            ImageUrl= imgUrl,
            Surname = doctor.Surname
        };

        if (doctor is not null) _doctorRepository.Add(myDoctor);
        return RedirectToAction(nameof(Index));
    }
}
