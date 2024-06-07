using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Data;


[Route("api/[controller]")]
[ApiController]
public class PatientsController : ControllerBase
{
    private readonly PatientContext _context;

    public PatientsController(PatientContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Patient>>> GetPatients()
    {
        return await _context.Patients.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Patient>> GetPatient(int id)
    {
        var patient = await _context.Patients.FindAsync(id);

        if (patient == null)
        {
            return NotFound();
        }

        return patient;
    }

    [HttpPost]
    public async Task<ActionResult<Patient>> PostPatient(Patient patient)
    {
        _context.Patients.Add(patient);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetPatient), new { id = patient.PatientId }, patient);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutPatient(int id, Patient patient)
    {
        if (id != patient.PatientId)
        {
            return BadRequest();
        }

        _context.Entry(patient).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PatientExists(id))
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
    public async Task<IActionResult> DeletePatient(int id)
    {
        var patient = await _context.Patients.FindAsync(id);
        if (patient == null)
        {
            return NotFound();
        }

        _context.Patients.Remove(patient);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool PatientExists(int id)
    {
        return _context.Patients.Any(e => e.PatientId == id);
    }
}




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
//     public class PatientsController : Controller
//     {
//         private readonly PatientContext _context;
//
//         public PatientsController(PatientContext context)
//         {
//             _context = context;
//         }
//
//         // GET: Patients
//         public async Task<IActionResult> Index()
//         {
//             return View(await _context.Patients.ToListAsync());
//         }
//
//         // GET: Patients/Details/5
//         public async Task<IActionResult> Details(int? id)
//         {
//             if (id == null)
//             {
//                 return NotFound();
//             }
//
//             var patient = await _context.Patients
//                 .FirstOrDefaultAsync(m => m.PatientPatientId == id);
//             if (patient == null)
//             {
//                 return NotFound();
//             }
//
//             return View(patient);
//         }
//
//         // GET: Patients/Create
//         public IActionResult Create()
//         {
//             return View();
//         }
//
//         // POST: Patients/Create
//         // To protect from overposting attacks, enable the specific properties you want to bind to.
//         // For more details, see http://go.microsoft.com/fwlink/?LinkPatientId=317598.
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public async Task<IActionResult> Create([Bind("PatientPatientId,Name,LastName,Address,Phone,Email")] Patient patient)
//         {
//             if (ModelState.IsValid)
//             {
//                 _context.Add(patient);
//                 await _context.SaveChangesAsync();
//                 return RedirectToAction(nameof(Index));
//             }
//             return View(patient);
//         }
//
//         // GET: Patients/Edit/5
//         public async Task<IActionResult> Edit(int? id)
//         {
//             if (id == null)
//             {
//                 return NotFound();
//             }
//
//             var patient = await _context.Patients.FindAsync(id);
//             if (patient == null)
//             {
//                 return NotFound();
//             }
//             return View(patient);
//         }
//
//         // POST: Patients/Edit/5
//         // To protect from overposting attacks, enable the specific properties you want to bind to.
//         // For more details, see http://go.microsoft.com/fwlink/?LinkPatientId=317598.
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public async Task<IActionResult> Edit(int id, [Bind("PatientPatientId,Name,LastName,Address,Phone,Email")] Patient patient)
//         {
//             if (id != patient.PatientPatientId)
//             {
//                 return NotFound();
//             }
//
//             if (ModelState.IsValid)
//             {
//                 try
//                 {
//                     _context.Update(patient);
//                     await _context.SaveChangesAsync();
//                 }
//                 catch (DbUpdateConcurrencyException)
//                 {
//                     if (!PatientExists(patient.PatientPatientId))
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
//             return View(patient);
//         }
//
//         // GET: Patients/Delete/5
//         public async Task<IActionResult> Delete(int? id)
//         {
//             if (id == null)
//             {
//                 return NotFound();
//             }
//
//             var patient = await _context.Patients
//                 .FirstOrDefaultAsync(m => m.PatientPatientId == id);
//             if (patient == null)
//             {
//                 return NotFound();
//             }
//
//             return View(patient);
//         }
//
//         // POST: Patients/Delete/5
//         [HttpPost, ActionName("Delete")]
//         [ValidateAntiForgeryToken]
//         public async Task<IActionResult> DeleteConfirmed(int id)
//         {
//             var patient = await _context.Patients.FindAsync(id);
//             if (patient != null)
//             {
//                 _context.Patients.Remove(patient);
//             }
//
//             await _context.SaveChangesAsync();
//             return RedirectToAction(nameof(Index));
//         }
//
//         private bool PatientExists(int id)
//         {
//             return _context.Patients.Any(e => e.PatientPatientId == id);
//         }
//     }
// }
