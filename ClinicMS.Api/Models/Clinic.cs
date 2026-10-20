using Microsoft.AspNetCore.Mvc;
namespace CampusEvents.Api.Model;

[Route("api/Clinics")]
public class Clinic
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Location { get; set; }
}
