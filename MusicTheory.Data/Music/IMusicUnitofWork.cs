            using System;
using MusicTheory.Data.Music;
using MusicTheory.Data;

public interface IMusicUnitOfWork : IUnitOfWork
{
    IScalenoteRepository ScaleNotes { get; }
    IChordconfigurationRepository ChordConfigurations { get; }
    IChordnoteRepository ChordNotes { get; }
    IChordnoteconfigurationRepository ChordNoteConfigurations { get; }
    INoteconfigurationRepository NoteConfigurations { get; }
    IMusickeyRepository MusicKeys { get; }
    IScaleconfigurationRepository ScaleConfigurations { get; }
    IMusiccontextfactoryRepository MusicContextFactorys { get; }
    IScalenoteconfigurationRepository ScaleNoteConfigurations { get; }
    IScaleRepository Scales { get; }
    INoteRepository Notes { get; }
    IMusickeyconfigurationRepository MusicKeyConfigurations { get; }
    IChordRepository Chords { get; }
    	
//Change this to the context type
IMusicContext Context();
void Complete();

}
