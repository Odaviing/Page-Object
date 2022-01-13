using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationPractice.Page_Objects
{
    class TopsPage : Header
    {
        public TopsPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
