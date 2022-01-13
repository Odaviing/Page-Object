using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationPractice.Page_Objects
{
    class WomenPage : Header
    {
        public WomenPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
