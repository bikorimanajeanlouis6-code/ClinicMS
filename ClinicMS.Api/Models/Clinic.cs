using Microsoft.AspNetCore.Mvc;

namespace ClinicMS.Api.Models;

[Route("api/Clinics")]
public class Clinic
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
}
