namespace ClinicMS.Api.DTOs;
using System.ComponentModel.DataAnnotations;
public class PaymentDTO
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Consultation { get; set; }
     [Required]
    public string Appointment { get; set; }
     [Required]
    public string Amount { get; set; }
     [Required]
    public DateTime Date { get; set; }
  
}