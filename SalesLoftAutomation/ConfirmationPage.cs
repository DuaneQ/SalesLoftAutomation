using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SalesLoftAutomation
{
    public class ConfirmationPage
    {
        public static bool IsAt
        {
            get
            {
                IWebElement text = Driver.Instance.FindElement(Tokens.CONF_MESSAGE);
                var conText = text.Text;
                if (conText == "We Sent You An Email!")
                    return true;
                return false;
                
            }
            
        }
    }
}
