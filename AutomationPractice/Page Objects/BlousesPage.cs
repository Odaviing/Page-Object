using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationPractice.Page_Objects
{
    class BlousesPage : Header
    {
        public BlousesPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
