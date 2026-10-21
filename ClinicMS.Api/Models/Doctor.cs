using Microsoft.AspNetCore.Mvc;

namespace ClinicMS.Api.Models;

[Route("api/Doctors")]
public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Specialty { get; set; } = string.Empty;
    public string Experience { get; set; } = string.Empty;
}