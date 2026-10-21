using ClinicMS.Api.Data;
using ClinicMS.Api.DTOs;
using ClinicMS.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicMS.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DoctorsController : ControllerBase
{
    private readonly AppDbContext _context;

    public DoctorsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<DoctorDTO>>> GetAll()
    {
        var doctors = await _context.Doctors
            .OrderBy(d => d.Id)
            .Select(d => new DoctorDTO
            {
                Id = d.Id,
                Name = d.Name,
                Email = d.Email,
                PhoneNumber = d.PhoneNumber,
                Specialty = d.Specialty,
                Experience = d.Experience
            })
            .ToListAsync();

        return Ok(doctors);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<DoctorDTO>> GetById(int id)
    {
        var doctor = await _context.Doctors
            .Where(d => d.Id == id)
            .Select(d => new DoctorDTO
            {
                Id = d.Id,
                Name = d.Name,
                Email = d.Email,
                PhoneNumber = d.PhoneNumber,
                Specialty = d.Specialty,
                Experience = d.Experience
            })
            .FirstOrDefaultAsync();

        return doctor is null ? NotFound() : Ok(doctor);
    }

    [HttpPost]
    public async Task<ActionResult<DoctorDTO>> Create(DoctorDTO dto)
    {
        var doctor = new Doctor
        {
            Name = dto.Name,
            Email = dto.Email,
            PhoneNumber = dto.PhoneNumber,
            Specialty = dto.Specialty,
            Experience = dto.Experience
        };

        _context.Doctors.Add(doctor);
        await _context.SaveChangesAsync();

        dto.Id = doctor.Id;
        return CreatedAtAction(nameof(GetById), new { id = doctor.Id }, dto);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, DoctorDTO dto)
    {
        var doctor = await _context.Doctors.FindAsync(id);
        if (doctor is null)
        {
            return NotFound();
        }

        doctor.Name = dto.Name;
        doctor.Email = dto.Email;
        doctor.PhoneNumber = dto.PhoneNumber;
        doctor.Specialty = dto.Specialty;
        doctor.Experience = dto.Experience;

        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var doctor = await _context.Doctors.FindAsync(id);
        if (doctor is null)
        {
            return NotFound();
        }

        _context.Doctors.Remove(doctor);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}