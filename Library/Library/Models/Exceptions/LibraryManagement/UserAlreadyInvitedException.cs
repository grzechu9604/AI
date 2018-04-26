using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models.Exceptions.LibraryManagement
{
    public class UserAlreadyInvitedException : Exception
    {
        private const string communicate = "Użytkownik już został zaproszony!";
        public UserAlreadyInvitedException() : base(communicate)
        { }
    }
}