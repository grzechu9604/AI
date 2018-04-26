using Library.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models.Exceptions.LibraryManagement;
using Library.Models.Books;

namespace Library.Models.LibraryManagement
{
    public class Library
    {
        private User _owner;
        private List<string> _invitedEmails;
        private List<User> _invitedUsers;
        private List<BookSpecimen> _books;

        public User Owner
        {
            get
            {
                return _owner;
            }

            set
            {
                _owner = value;
            }
        }

        public List<BookSpecimen> Books
        {
            get
            {
                return _books;
            }

            private set
            {
                _books = value;
            }
        }

        public Library(User _owner)
        {
            this.Owner = _owner;
            _invitedEmails = new List<string>();
            _invitedUsers = new List<User>();
            _books = new List<BookSpecimen>();
        }

        public void AddEmailToInvitedList(string mail)
        {
            if (_invitedEmails.Contains(mail) || _invitedUsers.Any(invitedUser => invitedUser.Mail.Equals(mail)))
            {
                throw new UserAlreadyInvitedException();
            }

            _invitedEmails.Add(mail);
        }

        public void ConfirmEmailInvitation(User u, string mail)
        {
            if (!u.Mail.Equals(mail) || !_invitedEmails.Contains(mail) || _invitedUsers.Contains(u))
            {
                throw new NotAllowedException();
            }

            _invitedUsers.Add(u);
        }

        public bool HasRightsLibrary(User u)
        {
            return Owner.Equals(u) || _invitedUsers.Any(invitedUser => invitedUser.Equals(u));
        }
    }
}