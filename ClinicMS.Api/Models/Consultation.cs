using Microsoft.AspNetCore.Mvc;

namespace ClinicMS.Api.Models;

[Route("api/Consultations")]
public class Consultation
{
    public int Id { get; set; }
    public Doctor? Doctor { get; set; }
    public Clinic? Clinic { get; set; }
    public Patient? Patient { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; } = string.Empty;
}