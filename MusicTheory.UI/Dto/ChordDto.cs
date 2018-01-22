using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicTheory.UI.Dto
{
    public class ChordDto
    {
        public int ChordId { get; set; } // ChordId (Primary key)
        public string ChordName { get; set; } // ChordName
        public IEnumerable<ChordNoteDto> ChordNotes { get; set; } // ChordNote.FK_Chord_ChordNote
    }
}