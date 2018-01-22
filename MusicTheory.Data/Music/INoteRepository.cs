
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using MusicTheory.Data.Music;
using MusicTheory.Data;

public interface INoteRepository : IRepository<Note>
{
    //Add any additional repository methods other than the generic ones (GetAll, GetById, Delete, Add)
    IEnumerable<Note> GetTuning(List<int> notes);
    IEnumerable<Note> GetTuning(List<int> notes, int numberStrings);

}
