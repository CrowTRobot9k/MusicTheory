using MusicTheory.Data;
using MusicTheory.Data.Music;

public class MusicUnitOfWork : IMusicUnitOfWork
{
    private MusicContext _context;

    //public UnitOfWork(MusicContext context)
    //{
       // _context = context;
    //}

	//Delete this default constructor if using an IoC container
	public MusicUnitOfWork()
	{
		_context = new MusicContext();
	}
	
    public IScalenoteRepository ScaleNotes => new ScalenoteRepository(_context);

    public IChordconfigurationRepository ChordConfigurations => new ChordconfigurationRepository(_context);

    public IChordnoteRepository ChordNotes => new ChordnoteRepository(_context);

    public IChordnoteconfigurationRepository ChordNoteConfigurations => new ChordnoteconfigurationRepository(_context);

    public INoteconfigurationRepository NoteConfigurations => new NoteconfigurationRepository(_context);

    public IMusickeyRepository MusicKeys => new MusickeyRepository(_context);

    public IScaleconfigurationRepository ScaleConfigurations => new ScaleconfigurationRepository(_context);

    public IMusiccontextfactoryRepository MusicContextFactorys => new MusiccontextfactoryRepository(_context);

    public IScalenoteconfigurationRepository ScaleNoteConfigurations => new ScalenoteconfigurationRepository(_context);

    public IScaleRepository Scales => new ScaleRepository(_context);

    public INoteRepository Notes => new NoteRepository(_context);

    public IMusickeyconfigurationRepository MusicKeyConfigurations => new MusickeyconfigurationRepository(_context);

    public IChordRepository Chords => new ChordRepository(_context);

    
	public IMusicContext Context()
	{
		return _context;
	}
	
    public void Complete()
    {
        _context.SaveChanges();
    }

}
