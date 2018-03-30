             
using MusicTheory.Data;		   
using MusicTheory.Data.Music;

              
public class MusiccontextfactoryRepository : Repository<MusicContextFactory>, IMusiccontextfactoryRepository
{

    public MusiccontextfactoryRepository(IMusicContext context) : base(context)
    {

    }

    //Override any generic method for your own custom implemention, add new repository methods to the IMusiccontextfactoryRepository.cs file
}
