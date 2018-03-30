             
using MusicTheory.Data;		   
using MusicTheory.Data.Music;

              
public class ScaleconfigurationRepository : Repository<ScaleConfiguration>, IScaleconfigurationRepository
{

    public ScaleconfigurationRepository(IMusicContext context) : base(context)
    {

    }

    //Override any generic method for your own custom implemention, add new repository methods to the IScaleconfigurationRepository.cs file
}
