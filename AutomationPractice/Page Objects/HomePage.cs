using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationPractice.Page_Objects
{
    class HomePage : Header
    {
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
