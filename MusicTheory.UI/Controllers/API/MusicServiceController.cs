using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicTheory.Data.Music;
using MusicTheory.UI.Dto;

namespace MusicTheory.UI.Controllers.API
{
    public class MusicServiceController : BaseApiController
    {
        public MusicServiceController(IMusicUnitOfWork musicUnitOfWork) : base(musicUnitOfWork)
        {

        }
        public IEnumerable<Note> GetNotes()
        {
            var notes = MusicUnitOfWork.Notes.GetAll().ToList();

            return notes;
        }
        public IEnumerable<MusicKey> GetKeys()
        {
            var keys = MusicUnitOfWork.MusicKeys.GetAll().ToList();

            return keys;
        }
        public IEnumerable<ChordDto> GetChords()
        {
            var chords = AutoMapper.Mapper.Map<IEnumerable<ChordDto>>(MusicUnitOfWork.Chords.GetAll().ToList());

            return chords;
        }
    }
}