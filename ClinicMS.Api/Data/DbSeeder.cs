using ClinicMS.Api.Models;

namespace ClinicMS.Api.Data;

public static class DbSeeder
{
    public static void SeedDatabase(AppDbContext dbContext)
    {
        if (!dbContext.Doctors.Any())
        {
            dbContext.Doctors.Add(new Doctor
            {
                Name = "Dr. John Doe",
                Specialty = "Cardiology",
                Email = "john.doe@example.com",
                PhoneNumber = "123-456-7890",
                Experience = "10 years"
            });

            dbContext.SaveChanges();
        }
    }
}