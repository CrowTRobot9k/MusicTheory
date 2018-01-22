             
using MusicTheory.Data;		   
using MusicTheory.Data.Music;

              
public class ChordnoteconfigurationRepository : Repository<ChordNoteConfiguration>, IChordnoteconfigurationRepository
{

    public ChordnoteconfigurationRepository(IMusicContext context) : base(context)
    {

    }

    //Override any generic method for your own custom implemention, add new repository methods to the IChordnoteconfigurationRepository.cs file
}
