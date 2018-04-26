using Library.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models.Books
{
    public class BookSpecimen
    {
        private Book _book;
        private HistoryOfBorrowing _historyOfBorrowing;
        private User _owner;
    }
}