using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SalesLoftAutomation
{
    public class RegistrationPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://accounts.salesloft.com/sign_up");

        }

        public static LoginCommand LoginAs(string firstName, string lastName, string company, string title, string email)
        {
            return new LoginCommand(firstName, lastName, company, title, email);
        }
    }

    public class LoginCommand
    {
        private string firstName;
        private string lastName;
        private string password;
        private string company;
        private string title;
        private string email;

        public LoginCommand(string firstName, string lastName, string company, string title, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.company = company;
            this.title = title;
            this.email = email;
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        //Send keys to field objects on the page
        public void Login()
        {
            Driver.Instance.FindElement(Tokens.FIRST_NAME).SendKeys(firstName);
            
            Driver.Instance.FindElement(Tokens.LAST_NAME).SendKeys(lastName);

            Driver.Instance.FindElement(Tokens.COMPANY).SendKeys(company);

            Driver.Instance.FindElement(Tokens.JOB_TITLE).SendKeys(title);

            Driver.Instance.FindElement(Tokens.EMAIL).SendKeys(email);

            Driver.Instance.FindElement(Tokens.PASSWORD).SendKeys(password);

            Driver.Instance.FindElement(Tokens.PWORD_CONF).SendKeys(password);
            
            Driver.Instance.FindElement(Tokens.SUBMIT).Click();

        }
    }
}
