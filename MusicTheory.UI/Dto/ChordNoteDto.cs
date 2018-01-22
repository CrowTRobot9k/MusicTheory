using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicTheory.UI.Dto
{
    public class ChordNoteDto
    {
        public int ChordNoteId { get; set; } // ChordNoteId (Primary key)
        public int ChordId { get; set; } // ChordId
        public int? Interval { get; set; } // Interval
    }
}