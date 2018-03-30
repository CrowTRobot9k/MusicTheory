             
using MusicTheory.Data;		   
using MusicTheory.Data.Music;

              
public class ScaleRepository : Repository<Scale>, IScaleRepository
{

    public ScaleRepository(IMusicContext context) : base(context)
    {

    }

    //Override any generic method for your own custom implemention, add new repository methods to the IScaleRepository.cs file
}
