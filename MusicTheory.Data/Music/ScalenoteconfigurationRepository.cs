             
using MusicTheory.Data;		   
using MusicTheory.Data.Music;

              
public class ScalenoteconfigurationRepository : Repository<ScaleNoteConfiguration>, IScalenoteconfigurationRepository
{

    public ScalenoteconfigurationRepository(IMusicContext context) : base(context)
    {

    }

    //Override any generic method for your own custom implemention, add new repository methods to the IScalenoteconfigurationRepository.cs file
}
