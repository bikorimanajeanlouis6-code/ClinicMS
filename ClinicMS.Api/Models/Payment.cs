using Microsoft.AspNetCore.Mvc;
namespace CampusEvents.Api.Model;

[Route("api/payments")]
public class Payment
{
    public int Id { get; set; }
    public Consultation Consultation { get; set; }
    public Appointment Appointment { get; set; }
    public string Amount { get; set; }
    public DateTime Date { get; set; }
}