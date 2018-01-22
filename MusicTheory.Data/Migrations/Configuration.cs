using System.Collections.Generic;
using MusicTheory.Data.Music;

namespace MusicTheory.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MusicTheory.Data.Music.MusicContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MusicTheory.Data.Music.MusicContext context)
        {
            //  This method will be called after migrating to the latest version.
            SeedNotes(context);
            SeedMusicKeys(context);
            SeedScales(context);
            SeedChords(context);
        }

        private static void SeedNotes(MusicTheory.Data.Music.MusicContext context)
        {
            context.Notes.AddOrUpdate
              (
              n => n.NoteName,
              new Note { NoteName = "A" },
              new Note { NoteName = "A#/Bb" },
              new Note { NoteName = "B" },
              new Note { NoteName = "C" },
              new Note { NoteName = "C#/Db" },
              new Note { NoteName = "D" },
              new Note { NoteName = "D#/Eb" },
              new Note { NoteName = "E" },
              new Note { NoteName = "F" },
              new Note { NoteName = "F#/Gb" },
              new Note { NoteName = "G" },
              new Note { NoteName = "G#/Ab" }
              );
        }

        private static void SeedScales(MusicTheory.Data.Music.MusicContext context)
        {
            var majorScale = new Scale
            {
                ScaleName = "Major",
                ScaleNotes = new List<ScaleNote>()
                {
                    new ScaleNote() {Interval = 2},
                    new ScaleNote() {Interval = 2},
                    new ScaleNote() {Interval = 1},
                    new ScaleNote() {Interval = 2},
                    new ScaleNote() {Interval = 2},
                    new ScaleNote() {Interval = 2},
                    new ScaleNote() {Interval = 1}
                }.ToList()
            };

            var minorScale = new Scale
            {
                ScaleName = "Minor",
                ScaleNotes = new List<ScaleNote>()
                {
                    new ScaleNote() {Interval = 2},
                    new ScaleNote() {Interval = 1},
                    new ScaleNote() {Interval = 2},
                    new ScaleNote() {Interval = 2},
                    new ScaleNote() {Interval = 1},
                    new ScaleNote() {Interval = 2},
                    new ScaleNote() {Interval = 2}
                }.ToList()
            };

            var harmonicMinorScale = new Scale
            {
                ScaleName = "HarmonicMinor",
                ScaleNotes = new List<ScaleNote>()
                {
                    new ScaleNote() {Interval = 2},
                    new ScaleNote() {Interval = 1},
                    new ScaleNote() {Interval = 2},
                    new ScaleNote() {Interval = 2},
                    new ScaleNote() {Interval = 1},
                    new ScaleNote() {Interval = 3},
                    new ScaleNote() {Interval = 1}
                }.ToList()
            };

            var pentatonicScale = new Scale
            {
                ScaleName = "Pentatonic",
                ScaleNotes = new List<ScaleNote>()
                {
                    new ScaleNote() {Interval = 3},
                    new ScaleNote() {Interval = 2},
                    new ScaleNote() {Interval = 1},
                    new ScaleNote() {Interval = 1},
                    new ScaleNote() {Interval = 3},
                    new ScaleNote() {Interval = 2}
                }.ToList()
            };

            context.Scales.AddOrUpdate(
                n => n.ScaleName
                , majorScale
                , minorScale
                ,harmonicMinorScale
                ,pentatonicScale);
        }

        private static void SeedChords(MusicTheory.Data.Music.MusicContext context)
        {
            context.Chords.AddOrUpdate
                (
                    c => c.ChordName,
                    new Chord()
                    {
                        ChordName = "Major",
                        ChordNotes = new List<ChordNote>()
                        {
                            new ChordNote() {Interval = 4},
                            new ChordNote() {Interval = 3}
                        }
                    },
                    new Chord()
                    {
                        ChordName = "Minor",
                        ChordNotes = new List<ChordNote>()
                        {
                            new ChordNote() {Interval = 3},
                            new ChordNote() {Interval = 4}
                        }
                    }
                );
        }

        private static void SeedMusicKeys(MusicTheory.Data.Music.MusicContext context)
        {
            context.MusicKeys.AddOrUpdate(m => m.MusicKey_,
                new MusicKey()
                {
                    MusicKey_ = "Major"
                },
                new MusicKey()
                {
                    MusicKey_ = "Minor"
                },
                new MusicKey()
                {
                    MusicKey_ = "HarmonicMinor"
                },
                new MusicKey()
                {
                    MusicKey_ = "Pentatonic"
                });
        }
    }
}
