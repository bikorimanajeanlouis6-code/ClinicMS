namespace ClinicMS.Api.DTOs;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ClinicMS.Api.Models;

public class ConsultationDTO
{
    [Required]
    public int Id { get; set; }

    [Required]
    public int DoctorId { get; set; }

    [ForeignKey(nameof(DoctorId))]
    public Doctor Doctor { get; set; }

    [Required]
    public int PatientId { get; set; }

    [ForeignKey(nameof(PatientId))]
    public Patient Patient { get; set; }

    [Required]
    public int AppointmentId { get; set; }

    [ForeignKey(nameof(AppointmentId))]
    public Appointment Appointment { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public string Location { get; set; } = string.Empty;
}

public class ConsultationCreateDTO
{
    [Required]
    public int DoctorId { get; set; }

    [Required]
    public int PatientId { get; set; }

    [Required]
    public int AppointmentId { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public string Location { get; set; } = string.Empty;
}
