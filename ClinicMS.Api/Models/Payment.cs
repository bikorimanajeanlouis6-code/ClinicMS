using Microsoft.AspNetCore.Mvc;

namespace ClinicMS.Api.Models;

[Route("api/payments")]
public class Payment
{
    public int Id { get; set; }
    public int Consultation { get; set; }
    public int Appointment { get; set; }
    public string Amount { get; set; } = string.Empty;
    public DateTime Date { get; set; }
}