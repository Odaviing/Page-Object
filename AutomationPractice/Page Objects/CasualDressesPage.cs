using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationPractice.Page_Objects
{
    class CasualDressesPage : Header
    {
        public CasualDressesPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
