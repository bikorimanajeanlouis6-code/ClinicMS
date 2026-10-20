using Microsoft.AspNetCore.Mvc;
namespace CampusEvents.Api.Model;

[Route("api/Doctors")]
public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Specialty { get; set; }
    public string Experience { get; set; }

}