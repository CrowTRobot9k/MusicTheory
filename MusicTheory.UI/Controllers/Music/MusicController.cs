using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Web.Mvc;
using MusicTheory.Data.Music;
using MusicTheory.UI.ViewModels;

namespace MusicTheory.UI.Controllers.Music
{
    public class MusicController : BaseController
    {
        public MusicController(IMusicUnitOfWork musicUnitOfWork) : base(musicUnitOfWork)
        {
        }

        public ActionResult Index()
        {
            var notes = MusicUnitOfWork.Notes.GetAll().ToList();
            var tuning = MusicUnitOfWork.Notes.GetTuning(new List<int>() { 8,3,11,6,1,8}).ToList();

            var model = new GuitarVM(notes,tuning,13);
            
            return View(model);
        }

        [HttpPost]
        public ActionResult ViewNotes(GuitarVM model)
        {
            if (!ModelState.IsValid)
            {
                foreach (ModelState modelState in ViewData.ModelState.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        var theError=(error);
                    }
                }

                return View("Index",model);
            }

            var scale = MusicUnitOfWork.Scales.Where(s => s.ScaleId == model.KeyId).FirstOrDefault();
            var rootNote = new Note();
            if (!string.IsNullOrEmpty(model.CurrentNote))
            {
                rootNote = MusicUnitOfWork.Notes.Where(n => n.NoteName == model.CurrentNote).FirstOrDefault();
            }
            else
            {
               rootNote= MusicUnitOfWork.Notes.Where(n => n.NoteId == model.NoteId).FirstOrDefault();
            }
           
            var notes = MusicUnitOfWork.Notes.GetAll().ToList();
            var chord = MusicUnitOfWork.Chords.Where(i => i.ChordId == model.ChordId).FirstOrDefault();
            var tuning = MusicUnitOfWork.Notes.GetTuning(model.Tuning.Select(i=>i.NoteId).ToList(), model.NumberOfStrings).ToList();
            model.Tuning = tuning;
            //take into account open string.
            model.NumberOfFrets = model.NumberOfFrets + 1;
            model.Guitar = new Guitar(notes,tuning,model.NumberOfFrets);
            model.Guitar.ShowScale(rootNote, scale);
            model.Guitar.ShowChord(notes, rootNote, chord, model.CurrentFret);


            return View("Index",model);
            
        }
    }
}
