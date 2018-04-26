using Library.Models.Exceptions.UsersManagementExceptions;
using System;

namespace Library.Models.Users
{
    public class User
    {
        private string _login;
        private string _mail;
        private string _encryptedPassword;
        private DateTime _createDate;
        private DateTime? _confirmationDate;

        public string Login
        {
            get
            {
                return _login;
            }

            private set
            {
                _login = value;
            }
        }

        public string Mail
        {
            get
            {
                return _mail;
            }

            private set
            {
                _mail = value;
            }
        }

        public User(string login, string mail, string encryptedPassword)
        {
            Login = login;
            Mail = mail;
            _encryptedPassword = encryptedPassword;
            _createDate = DateTime.Now;
        }

        public void VerifyUserCreation()
        {
            if(_confirmationDate.HasValue)
            {
                throw new UserAlreadyConfirmedException();
            }

            _confirmationDate = DateTime.Now;
        }

        public bool VerifyPassword(string encryptedPassword)
        {
            if (!_confirmationDate.HasValue)
            {
                throw new UserNotConfirmedException();
            }

            return encryptedPassword.Equals(_encryptedPassword);
        }
    }
}