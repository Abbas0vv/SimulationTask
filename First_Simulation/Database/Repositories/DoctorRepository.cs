using First_Simulation.Database.Models;

namespace First_Simulation.Database.Repositories;

public class DoctorRepository
{
    private readonly AppDbContext _dbContext;

    public DoctorRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public List<Doctor> GetAll()
    {
        return _dbContext.Doctors.ToList();
    }

    public Doctor GetById(int id)
    {
        var doctor = _dbContext.Doctors.FirstOrDefault(x => x.Id == id);
        return doctor;
    }

    public void DeleteById(int id)
    {
        var doctor = GetById(id);
        _dbContext.Doctors.Remove(doctor);
        _dbContext.SaveChanges();
    }
    public void Add(Doctor doctor)
    {
        _dbContext.Doctors.Add(doctor);
        _dbContext.SaveChanges();
    }
}
