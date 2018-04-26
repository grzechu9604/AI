using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models.Exceptions.UsersManagementExceptions;


namespace Library.Models.Users.Tests
{
    [TestClass()]
    public class UserTests
    {
        private User privateUser;
        private string login = "ABC";
        private string mail = "FGH";
        private string encryptedPassword = "EFG";
        private string incorrectPassword = "XYZ";

        [TestMethod()]
        [ExpectedException(typeof(UserNotConfirmedException))]
        public void VerifyPasswordTestUserNotConfirmed()
        {
            privateUser = new User(login, mail, encryptedPassword);
            privateUser.VerifyPassword(incorrectPassword);
        }

        [TestMethod()]
        public void VerifyPasswordTestIncorrectPassword()
        {
            privateUser = new User(login, mail, encryptedPassword);
            privateUser.VerifyUserCreation();
            Assert.AreEqual(false, privateUser.VerifyPassword(incorrectPassword));
        }

        [TestMethod()]
        public void VerifyPasswordTestCorrectPassword()
        {
            privateUser = new User(login, mail, encryptedPassword);
            privateUser.VerifyUserCreation();
            Assert.AreEqual(true, privateUser.VerifyPassword(encryptedPassword));
        }

        [TestMethod()]
        [ExpectedException(typeof(UserAlreadyConfirmedException))]
        public void VerifyUserCreationTestDoubleVerification()
        {
            privateUser = new User(login, mail, encryptedPassword);
            privateUser.VerifyUserCreation();
            privateUser.VerifyUserCreation();
        }
    }
}