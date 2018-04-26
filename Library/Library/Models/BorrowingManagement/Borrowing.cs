using Library.Models.Exceptions.BorrowingManagement;
using Library.Models.Users;
using System;

namespace Library.Models.BorrowingManagement
{
    public class Borrowing
    {
        private User _borrower;
        private DateTime _dateFrom;
        private DateTime? _dateTo;

        public Borrowing(User _borrower, DateTime _dateFrom)
        {
            this._borrower = _borrower;
            this._dateFrom = _dateFrom;
        }

        public void GiveBack(DateTime dateTo)
        {
            if (DateTo.HasValue)
            {
                throw new BorrowingAlreadyEndedException();
            }

            DateTo = dateTo;
        }

        public void GiveBack()
        {
            GiveBack(DateTime.Now);
        }

        public User Borrower
        {
            get
            {
                return _borrower;
            }

            private set
            {
                _borrower = value;
            }
        }

        public DateTime DateFrom
        {
            get
            {
                return _dateFrom;
            }

            private set
            {
                _dateFrom = value;
            }
        }

        public DateTime? DateTo
        {
            get
            {
                return _dateTo;
            }

            private set
            {
                _dateTo = value;
            }
        }
    }
}