using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using MusicTheory.Data.Music;
using WebGrease.Css.Extensions;

namespace MusicTheory.UI.ViewModels
{
    public class GuitarString
    {
        public GuitarString()
        {
        }

        public GuitarString(Note startNote, List<Note> allNotes,int numberOfFrets)
        {
            Frets = new List<GuitarFret>();
            
            var startIndex = allNotes.IndexOf(startNote);
            var iter = 0;
            while (Frets.Count< numberOfFrets)
            {

                if (startIndex+iter >= allNotes.Count())
                {
                    startIndex = 0;
                    iter = 0;
                }
                Frets.Add(new GuitarFret(allNotes[startIndex+iter]));

                iter++;
            }

            StringRootNote = startNote;
        }

        public void ShowScale(Note startNote,Scale scale)
        {
            var rootNotes= Frets.Where(n => n.FretNote == startNote);

            rootNotes.ForEach(i=>i.CssClass= "btn btn-warning");

            var beginFret = Frets.FirstOrDefault(n => n.FretNote == startNote);
            var startIndex = Frets.IndexOf(beginFret);

            var loopTwice = Frets.Count()<=13?1:0;
            for (var i=0;i<scale.ScaleNotes.Count();i++)
            {

                var interval = (int)scale.ScaleNotes.ToList()[i].Interval;

                startIndex = startIndex + interval;

                //set octaves if hits octave.
                if (startIndex == Frets.Count() - 1)
                {
                    Frets[0].CssClass= "btn btn-warning";
                }

                //add one to what is virtually a linked list.
                Frets[startIndex < Frets.Count() ? startIndex: startIndex % Frets.Count()+1].CssClass = "btn btn-warning";

                //loop twice for all frets.
                if (i == scale.ScaleNotes.Count() - 1 && loopTwice==0)
                {
                    i = -1;
                    loopTwice = 1;
                }
            }

        }

        public void ShowChord(List<Note> notesInChord,int startFret)
        {
            Frets.GetRange(startFret, Frets.Count() - startFret)
                .FirstOrDefault(i => notesInChord.Select(n => n.NoteId).Contains(i.FretNote.NoteId))
                .CssClass = "btn btn-danger";
        }

        public Note StringRootNote { get; set; }

        public List<GuitarFret> Frets { get; set; }
    }
}