             
using MusicTheory.Data;		   
using MusicTheory.Data.Music;

              
public class MusickeyRepository : Repository<MusicKey>, IMusickeyRepository
{

    public MusickeyRepository(IMusicContext context) : base(context)
    {

    }

    //Override any generic method for your own custom implemention, add new repository methods to the IMusickeyRepository.cs file
}
