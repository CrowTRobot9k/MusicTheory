using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Web;
using MusicTheory.Data.Music;

namespace MusicTheory.UI.ViewModels
{
    public class Guitar
    {
        public Guitar()
        {
        }

        //Special Tuning
        public Guitar(List<Note> allNotes, List<Note> tuning,int numberOfFrets)
        {
            GuitarStrings= new List<GuitarString>();
            foreach (var openString in tuning)
            {
                var guitarString = new GuitarString(allNotes.FirstOrDefault(i => i == openString), allNotes, numberOfFrets);
                GuitarStrings.Add(guitarString);
            }
        }

        public void ShowScale(Note startNote, Scale scale)
        {
            foreach (var guitarString in GuitarStrings)
            {
                guitarString.ShowScale(startNote,scale);
            }
        }

        public void ShowChord(List<Note> allNotes, Note rootNote, Chord chord,int startFret)
        {
            var notesInChord = new List<Note>();

            notesInChord.Add(rootNote);
            foreach (var note in chord.ChordNotes)
            {
                var start= allNotes.IndexOf(notesInChord.Last());
                var interval = start + (int) note.Interval;
                var noteToAdd = allNotes[interval < allNotes.Count() ? interval : interval%allNotes.Count()];
                notesInChord.Add(noteToAdd);
            }

            foreach (var guitarString in GuitarStrings)
            {
                guitarString.ShowChord(notesInChord, startFret);
            }       
        }
              
        public List<GuitarString> GuitarStrings { get; set; }
    }
}