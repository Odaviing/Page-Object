using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;


namespace AutomationPractice.Page_Objects
{
    class ContactPage : Header
    {
        public ContactPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
