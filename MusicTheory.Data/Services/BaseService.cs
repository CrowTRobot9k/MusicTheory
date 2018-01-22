using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MusicTheory.Data.Services
{
    public abstract class BaseService
    {
        public IMusicUnitOfWork MusicUnitOfWork;
        protected BaseService(IMusicUnitOfWork musicUnitOfWork)
        {
            MusicUnitOfWork = musicUnitOfWork;

        }
    }
}
