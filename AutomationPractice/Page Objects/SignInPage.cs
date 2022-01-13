using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;


namespace AutomationPractice.Page_Objects
{
    class SignInPage: Header
    {
        public SignInPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
