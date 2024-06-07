using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Data;

[Route("api/[controller]")]
[ApiController]
public class NotesController : ControllerBase
{
    private readonly PatientContext _context;

    public NotesController(PatientContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Note>>> GetNotes()
    {
        return await _context.Notes.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Note>> GetNote(int id)
    {
        var note = await _context.Notes.FindAsync(id);

        if (note == null)
        {
            return NotFound();
        }

        return note;
    }

    [HttpPost]
    public async Task<ActionResult<Note>> PostNote(Note note)
    {
        _context.Notes.Add(note);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetNote), new { id = note.NoteId }, note);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutNote(int id, Note note)
    {
        if (id != note.NoteId)
        {
            return BadRequest();
        }

        _context.Entry(note).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!NoteExists(id))
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
    public async Task<IActionResult> DeleteNote(int id)
    {
        var note = await _context.Notes.FindAsync(id);
        if (note == null)
        {
            return NotFound();
        }

        _context.Notes.Remove(note);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool NoteExists(int id)
    {
        return _context.Notes.Any(e => e.NoteId == id);
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
//     public class NotesController : Controller
//     {
//         private readonly NoteContext _context;
//
//         public NotesController(NoteContext context)
//         {
//             _context = context;
//         }
//
//         // GET: Notes
//         public async Task<IActionResult> Index()
//         {
//             return View(await _context.Notes.ToListAsync());
//         }
//
//         // GET: Notes/Details/5
//         public async Task<IActionResult> Details(int? id)
//         {
//             if (id == null)
//             {
//                 return NotFound();
//             }
//
//             var note = await _context.Notes
//                 .FirstOrDefaultAsync(m => m.NoteNoteId == id);
//             if (note == null)
//             {
//                 return NotFound();
//             }
//
//             return View(note);
//         }
//
//         // GET: Notes/Create
//         public IActionResult Create()
//         {
//             return View();
//         }
//
//         // POST: Notes/Create
//         // To protect from overposting attacks, enable the specific properties you want to bind to.
//         // For more details, see http://go.microsoft.com/fwlink/?LinkNoteId=317598.
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public async Task<IActionResult> Create([Bind("NoteNoteId,NoteNoteId,Summary,Prescription")] Note note)
//         {
//             if (ModelState.IsValid)
//             {
//                 _context.Add(note);
//                 await _context.SaveChangesAsync();
//                 return RedirectToAction(nameof(Index));
//             }
//             return View(note);
//         }
//
//         // GET: Notes/Edit/5
//         public async Task<IActionResult> Edit(int? id)
//         {
//             if (id == null)
//             {
//                 return NotFound();
//             }
//
//             var note = await _context.Notes.FindAsync(id);
//             if (note == null)
//             {
//                 return NotFound();
//             }
//             return View(note);
//         }
//
//         // POST: Notes/Edit/5
//         // To protect from overposting attacks, enable the specific properties you want to bind to.
//         // For more details, see http://go.microsoft.com/fwlink/?LinkNoteId=317598.
//         [HttpPost]
//         [ValidateAntiForgeryToken]
//         public async Task<IActionResult> Edit(int id, [Bind("NoteNoteId,NoteNoteId,Summary,Prescription")] Note note)
//         {
//             if (id != note.NoteNoteId)
//             {
//                 return NotFound();
//             }
//
//             if (ModelState.IsValid)
//             {
//                 try
//                 {
//                     _context.Update(note);
//                     await _context.SaveChangesAsync();
//                 }
//                 catch (DbUpdateConcurrencyException)
//                 {
//                     if (!NoteExists(note.NoteNoteId))
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
//             return View(note);
//         }
//
//         // GET: Notes/Delete/5
//         public async Task<IActionResult> Delete(int? id)
//         {
//             if (id == null)
//             {
//                 return NotFound();
//             }
//
//             var note = await _context.Notes
//                 .FirstOrDefaultAsync(m => m.NoteNoteId == id);
//             if (note == null)
//             {
//                 return NotFound();
//             }
//
//             return View(note);
//         }
//
//         // POST: Notes/Delete/5
//         [HttpPost, ActionName("Delete")]
//         [ValidateAntiForgeryToken]
//         public async Task<IActionResult> DeleteConfirmed(int id)
//         {
//             var note = await _context.Notes.FindAsync(id);
//             if (note != null)
//             {
//                 _context.Notes.Remove(note);
//             }
//
//             await _context.SaveChangesAsync();
//             return RedirectToAction(nameof(Index));
//         }
//
//         private bool NoteExists(int id)
//         {
//             return _context.Notes.Any(e => e.NoteNoteId == id);
//         }
//     }
// }
