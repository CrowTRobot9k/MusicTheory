using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MusicTheory.UI.Controllers
{
    public abstract partial class BaseController : Controller
    {
        protected IMusicUnitOfWork MusicUnitOfWork;

        protected BaseController(IMusicUnitOfWork musicUnitOfWork)
        {
            MusicUnitOfWork = musicUnitOfWork;
        }

    }
}