using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models.Exceptions.UsersManagementExceptions
{
    public class UserAlreadyConfirmedException : Exception
    {
        private const string communicate = "Użytkownik był już zatwierdzony!";
        public UserAlreadyConfirmedException() : base(communicate)
        { }
    }
}