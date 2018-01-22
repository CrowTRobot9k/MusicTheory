using System.DirectoryServices.AccountManagement;
using MusicTheory.UI.Models;

namespace MusicTheory.UI.App_Start
{
    public interface IAdAuthenticationService
    {
        AuthenticationResult SignIn(string username, string password, ContextType contextType,
           string activeDirectoryLocation);
        AuthenticationResult Authenticate(string username, string password, ContextType contextType,
            string activeDirectoryLocation);
        void SignOut(string applicationCookie);
    }
}