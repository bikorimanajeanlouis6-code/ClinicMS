namespace ClinicMS.Api.DTOs;
using System.ComponentModel.DataAnnotations;

public class PatientDTO
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
     [Required]
    public string Email { get; set; }
     [Required]
    public string PhoneNumber { get; set; }
     [Required]
    public string Address { get; set; }

   
  
}