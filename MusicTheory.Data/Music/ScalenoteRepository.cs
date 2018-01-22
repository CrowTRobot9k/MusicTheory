
 
using MusicTheory.Data;		   
using MusicTheory.Data.Music;

              
public class ScalenoteRepository : Repository<ScaleNote>, IScalenoteRepository
{

    public ScalenoteRepository(IMusicContext context) : base(context)
    {

    }

    //Override any generic method for your own custom implemention, add new repository methods to the IScalenoteRepository.cs file
}
