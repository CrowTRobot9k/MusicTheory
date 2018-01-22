             
using MusicTheory.Data;		   
using MusicTheory.Data.Music;

              
public class ChordconfigurationRepository : Repository<ChordConfiguration>, IChordconfigurationRepository
{

    public ChordconfigurationRepository(IMusicContext context) : base(context)
    {

    }

    //Override any generic method for your own custom implemention, add new repository methods to the IChordconfigurationRepository.cs file
}
