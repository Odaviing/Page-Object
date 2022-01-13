using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationPractice.Page_Objects
{
    class DressesPage : Header
    {
        public DressesPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
