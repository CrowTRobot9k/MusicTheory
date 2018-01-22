using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicTheory.Data.Music;

namespace MusicTheory.UI.ViewModels
{
    public class GuitarVM
    {
        public GuitarVM()
        {
        }

        public GuitarVM(List<Note> allNotes, List<Note> tuning, int numberOfFrets)
        {
                NumberOfFrets = numberOfFrets;
                NumberOfStrings = tuning.Count();
                Tuning = tuning;
                AllNotes = allNotes;
                Guitar = new Guitar(allNotes, tuning, numberOfFrets);
        }
        public int NoteId { get; set; }
        public int KeyId { get; set; }
        public int ChordId { get; set; }
        public string Display { get; set; }
        public int NumberOfStrings { get; set; }
        public int CurrentString { get; set; }
        public string CurrentNote { get; set; }
        public int CurrentFret { get; set; }
        public int NumberOfFrets { get; set; }
        public List<Note> Tuning { get; set; }
        public List<Note> AllNotes { get; set; }
        public Guitar Guitar { get; set; }
    }
}