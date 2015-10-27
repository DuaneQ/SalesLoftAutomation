using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SalesLoftAutomation
{
    //Registration field objects
    public class Tokens
    {
        static public By FIRST_NAME = By.Id("first_name");
        static public By LAST_NAME = By.Id("last_name");
        static public By COMPANY = By.Id("company");
        static public By JOB_TITLE = By.Id("job_title");
        static public By EMAIL = By.Id("email");
        static public By PASSWORD = By.Id("password");
        static public By PWORD_CONF = By.Id("password_confirmation");
        static public By SUBMIT = By.ClassName("btn-primary");

        static public By CONF_MESSAGE = By.TagName("h3");
    }
}
