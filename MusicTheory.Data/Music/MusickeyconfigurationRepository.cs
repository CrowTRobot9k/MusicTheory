             
using MusicTheory.Data;		   
using MusicTheory.Data.Music;

              
public class MusickeyconfigurationRepository : Repository<MusicKeyConfiguration>, IMusickeyconfigurationRepository
{

    public MusickeyconfigurationRepository(IMusicContext context) : base(context)
    {

    }

    //Override any generic method for your own custom implemention, add new repository methods to the IMusickeyconfigurationRepository.cs file
}
