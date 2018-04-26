using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models.Exceptions.LibraryManagement
{
    public class NotAllowedException : Exception
    {
        private const string communicate = "Brak uprawnień do wykonania tej akcji!";
        public NotAllowedException() : base(communicate)
        { }
    }
}