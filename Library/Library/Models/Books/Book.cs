using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models.Books
{
    public class Book
    {
        private long _id;
        private string _author;
        private string _title;

        public string Author
        {
            get
            {
                return _author;
            }

            private set
            {
                _author = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            private set
            {
                _title = value;
            }
        }

        public long Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
    }
}