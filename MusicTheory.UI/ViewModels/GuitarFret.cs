using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicTheory.Data.Music;

namespace MusicTheory.UI.ViewModels
{
    public class GuitarFret
    {
        public GuitarFret() 
        {

        }

        public GuitarFret(Note note)
        {
            FretNote = note;
            CssClass = "btn btn-default";
        }

        public Note FretNote { get; set; }
        public string CssClass { get; set; }

    }
}