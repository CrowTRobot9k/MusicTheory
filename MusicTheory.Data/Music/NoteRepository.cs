             
using System.Collections.Generic;
using System.Linq;
using MusicTheory.Data;		   
using MusicTheory.Data.Music;

              
public class NoteRepository : Repository<Note>, INoteRepository
{

    public NoteRepository(IMusicContext context) : base(context)
    {

    }

    public IEnumerable<Note> GetTuning(List<int> noteIds)
    {
        return noteIds.Select(note => ((IMusicContext)Context).Notes.FirstOrDefault(i => i.NoteId == note)).ToList();
    }

    public IEnumerable<Note> GetTuning(List<int> noteIds,int numberStrings)
    {
        var tuning= noteIds.Select(note => ((IMusicContext) Context).Notes.FirstOrDefault(i => i.NoteId == note)).ToList();
        
        if (numberStrings > noteIds.Count())
        {
            var stringsToAdd = numberStrings - noteIds.Count();
            for (var i = 0; i < stringsToAdd; i++)
            {
                var last = tuning.Last();
                var noteToAdd =
                    ((IMusicContext) Context).Notes.FirstOrDefault(
                        n => n.NoteId == ((last.NoteId + 7) <= 12 ? last.NoteId + 7 : (last.NoteId + 7)%12));
                tuning.Add(noteToAdd);
            }
        }
        else if (numberStrings<noteIds.Count)
        {
            tuning.RemoveRange(numberStrings,noteIds.Count()-numberStrings);
        }
        return tuning;

    }

    //Override any generic method for your own custom implemention, add new repository methods to the INoteRepository.cs file
}
