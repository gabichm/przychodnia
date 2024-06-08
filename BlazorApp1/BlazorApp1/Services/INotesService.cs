using BlazorApp1.Models;
namespace BlazorApp1.Services;

public interface INotesService
{
    Task<List<Note>> GetNotes();
    Task<Note> GetNote(int id);
    Task<Note> AddNote(Note note);
    Task<Note> UpdateNote(Note note);
    Task DeleteNote(int id);

}
