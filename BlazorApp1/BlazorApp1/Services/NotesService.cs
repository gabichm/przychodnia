using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.services;

public class NotesService : INotesService
{
    private readonly ApplicationDbContext _context;
    
    public NoteService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Note>> GetNotes()
    {
        var notes = await _context.Notes.ToListAsync();
        return notes;
    }
    public async Task<Note> GetNote(int id)
    {
        var note = await _context.notes.FindAsync(id);
        return note;
    }
    public async Task<Note> AddNote(Note note)
    {
        _context.Notes.Add(note);
        await _context.SaveChangesAsync();
        return note;
    }
    public async Task<Note> UpdateNote(Note note)
    {
        _context.Entry(note).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return note;
    }
    public async Task DeleteNote(int id)
    {
        var note = await _context.Notes.FindAsync(id);
        _context.notes.Remove(note);
        await _context.SaveChangesAsync();
    }
    
}
