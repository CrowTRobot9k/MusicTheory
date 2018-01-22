             
using MusicTheory.Data;		   
using MusicTheory.Data.Music;

              
public class NoteconfigurationRepository : Repository<NoteConfiguration>, INoteconfigurationRepository
{

    public NoteconfigurationRepository(IMusicContext context) : base(context)
    {

    }

    //Override any generic method for your own custom implemention, add new repository methods to the INoteconfigurationRepository.cs file
}
