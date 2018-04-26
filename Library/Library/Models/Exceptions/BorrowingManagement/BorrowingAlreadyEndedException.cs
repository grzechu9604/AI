using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models.Exceptions.BorrowingManagement
{
    public class BorrowingAlreadyEndedException : Exception
    {
        private const string communicate = "Książka była już zwrócona!";
        public BorrowingAlreadyEndedException() : base(communicate)
        { }
    }
}