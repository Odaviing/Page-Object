using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationPractice.Page_Objects
{
    class TShirtsPage : Header
    {
        public TShirtsPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
