using Library.Models.BorrowingManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models.Books
{
    public class HistoryOfBorrowing
    {
        private List<Borrowing> borrowings = new List<Borrowing>();

        public void AddBorrowing(Borrowing b)
        {
            borrowings.Add(b);
        }

        public Borrowing GetNewestBorrowing()
        {
            return borrowings.Last();
        }
    }
}