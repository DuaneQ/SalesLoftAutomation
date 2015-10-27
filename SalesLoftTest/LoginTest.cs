using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesLoftAutomation;

namespace SalesLoftTest
{
    [TestClass]
    public class LoginTest
    {

        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void User_Can_Submit_Reg_Form()
        {
            //Open the registration page
            RegistrationPage.GoTo();

            //Input the required fields for the registration page and log in
            RegistrationPage
                .LoginAs("testuser", "account", "Sales Company", "Sales Assoc", "myemail9@terragotech.com")
                .WithPassword("password")
                .Login();

            //Confirm successful submission
            Assert.IsTrue(ConfirmationPage.IsAt);
        }

        //Shut down webdriver
        [TestCleanup]
        public void Cleanup()
        {
            Driver.Quit();
        }
    }
}
