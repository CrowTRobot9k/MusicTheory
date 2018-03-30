             
using MusicTheory.Data;		   
using MusicTheory.Data.Music;

              
public class NoteRepository : Repository<Note>, INoteRepository
{

    public NoteRepository(IMusicContext context) : base(context)
    {

    }

    //Override any generic method for your own custom implemention, add new repository methods to the INoteRepository.cs file
}
