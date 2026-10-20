using Microsoft.AspNetCore.Mvc;
namespace CampusEvents.Api.Model;

[Route("api/Patients")]
public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Sex { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
}