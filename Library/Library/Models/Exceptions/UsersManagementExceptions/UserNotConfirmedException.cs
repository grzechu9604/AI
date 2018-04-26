using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models.Exceptions.UsersManagementExceptions
{
    public class UserNotConfirmedException : Exception
    {
        private const string communicate = "Użytkownik nie został zatwierdzony";
        public UserNotConfirmedException() : base(communicate)
        { }
    }
}