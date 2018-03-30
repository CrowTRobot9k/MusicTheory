             
using MusicTheory.Data;		   
using MusicTheory.Data.Music;

              
public class ChordnoteRepository : Repository<ChordNote>, IChordnoteRepository
{

    public ChordnoteRepository(IMusicContext context) : base(context)
    {

    }

    //Override any generic method for your own custom implemention, add new repository methods to the IChordnoteRepository.cs file
}
