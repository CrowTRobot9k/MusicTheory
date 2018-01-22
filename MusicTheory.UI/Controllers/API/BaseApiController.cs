using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MusicTheory.UI.Controllers.API
{
    public abstract partial class BaseApiController : ApiController
    {
        protected IMusicUnitOfWork MusicUnitOfWork;

        protected BaseApiController(IMusicUnitOfWork musicUnitOfWork)
        {
            MusicUnitOfWork = musicUnitOfWork;
        }
    }
}