using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Data;

[Route("api/[controller]")]
[ApiController]
public class AppointmentsController : ControllerBase
{
    private readonly PatientContext _context;

    public AppointmentsController(PatientContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Appointment>>> GetAppointments()
    {
        return await _context.Appointments.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Appointment>> GetAppointment(int id)
    {
        var appointment = await _context.Appointments.FindAsync(id);

        if (appointment == null)
        {
            return NotFound();
        }

        return appointment;
    }

    [HttpPost]
    public async Task<ActionResult<Appointment>> PostAppointment(Appointment appointment)
    {
        _context.Appointments.Add(appointment);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetAppointment), new { id = appointment.AppointmentId }, appointment);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAppointment(int id, Appointment appointment)
    {
        if (id != appointment.AppointmentId)
        {
            return BadRequest();
        }

        _context.Entry(appointment).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!AppointmentExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAppointment(int id)
    {
        var appointment = await _context.Appointments.FindAsync(id);
        if (appointment == null)
        {
            return NotFound();
        }

        _context.Appointments.Remove(appointment);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool AppointmentExists(int id)
    {
        return _context.Appointments.Any(e => e.AppointmentId == id);
    }
}


//
//
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.EntityFrameworkCore;
// using Api.Data;
//
// namespace Api.Controllers
// {
// [ApiController]
// [Route("api/[controller]")]
//     public class AppointmentsController : Controller
//     {
//         private readonly AppointmentContext _context;
//
//         public AppointmentsController(AppointmentContext context)
//         {
//             _context = context;
//         }
//
//         // GET: Appointments
//         [HttpGet]
//         public async Task<IActionResult> Index()
//         {
//             return View(await _context.Appointments.ToListAsync());
//         }
//
//         // GET: Appointments/Details/5
//         [HttpGet("{id}")]
//         public async Task<IActionResult> Details(int? id)
//         {
//             if (id == null)
//             {
//                 return NotFound();
//             }
//
//             var appointment = await _context.Appointments
//                 .FirstOrDefaultAsync(m => m.AppointmentAppointmentId == id);
//             if (appointment == null)
//             {
//                 return NotFound();
//             }
//
//             return View(appointment);
//         }
//
//         // GET: Appointments/Create
//         public IActionResult Create()
//         {
//             return View();
//         }
//
//         // POST: Appointments/Create
//         // To protect from overposting attacks, enable the specific properties you want to bind to.
//         // For more details, see http://go.microsoft.com/fwlink/?LinkAppointmentId=317598.
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public async Task<IActionResult> Create([Bind("AppointmentAppointmentId,Date,Time,Reason,AppointmentAppointmentId,DoctorAppointmentId,Status")] Appointment appointment)
//         {
//             if (ModelState.IsValid)
//             {
//                 _context.Add(appointment);
//                 await _context.SaveChangesAsync();
//                 return RedirectToAction(nameof(Index));
//             }
//             return View(appointment);
//         }
//
//         // GET: Appointments/Edit/5
//         public async Task<IActionResult> Edit(int? id)
//         {
//             if (id == null)
//             {
//                 return NotFound();
//             }
//
//             var appointment = await _context.Appointments.FindAsync(id);
//             if (appointment == null)
//             {
//                 return NotFound();
//             }
//             return View(appointment);
//         }
//
//         // POST: Appointments/Edit/5
//         // To protect from overposting attacks, enable the specific properties you want to bind to.
//         // For more details, see http://go.microsoft.com/fwlink/?LinkAppointmentId=317598.
//         [HttpPost("{id}")]
//         [ValidateAntiForgeryToken]
//         public async Task<IActionResult> Edit(int id, [Bind("AppointmentAppointmentId,Date,Time,Reason,AppointmentAppointmentId,DoctorAppointmentId,Status")] Appointment appointment)
//         {
//             if (id != appointment.AppointmentAppointmentId)
//             {
//                 return NotFound();
//             }
//
//             if (ModelState.IsValid)
//             {
//                 try
//                 {
//                     _context.Update(appointment);
//                     await _context.SaveChangesAsync();
//                 }
//                 catch (DbUpdateConcurrencyException)
//                 {
//                     if (!AppointmentExists(appointment.AppointmentAppointmentId))
//                     {
//                         return NotFound();
//                     }
//                     else
//                     {
//                         throw;
//                     }
//                 }
//                 return RedirectToAction(nameof(Index));
//             }
//             return View(appointment);
//         }
//
//         // GET: Appointments/Delete/5
//         [HttpDelete("{id}")]
//         public async Task<IActionResult> Delete(int? id)
//         {
//             if (id == null)
//             {
//                 return NotFound();
//             }
//
//             var appointment = await _context.Appointments
//                 .FirstOrDefaultAsync(m => m.AppointmentAppointmentId == id);
//             if (appointment == null)
//             {
//                 return NotFound();
//             }
//
//             return View(appointment);
//         }
//
//         // POST: Appointments/Delete/5
//         [HttpPost, ActionName("Delete")]
//         [ValidateAntiForgeryToken]
//         public async Task<IActionResult> DeleteConfirmed(int id)
//         {
//             var appointment = await _context.Appointments.FindAsync(id);
//             if (appointment != null)
//             {
//                 _context.Appointments.Remove(appointment);
//             }
//
//             await _context.SaveChangesAsync();
//             return RedirectToAction(nameof(Index));
//         }
//
//         private bool AppointmentExists(int id)
//         {
//             return _context.Appointments.Any(e => e.AppointmentAppointmentId == id);
//         }
//     }
// }
