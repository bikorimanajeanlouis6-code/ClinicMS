namespace CampusEvents.Api.DTOs;
using System.ComponentModel.DataAnnotations;
 
 public class AppointmentDTO
 {
     [Required]
     public int DoctorId { get; set; }
 
     [Required]
     public int ClinicId { get; set; }
 
     [Required]
     public int PatientId { get; set; }
 
     [Required]
     public DateTime Date { get; set; }
 
     [Required]
     public string Location { get; set; }
 }