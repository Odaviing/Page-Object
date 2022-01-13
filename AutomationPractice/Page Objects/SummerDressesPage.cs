using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationPractice.Page_Objects
{
    class SummerDressesPage : Header
    {
        public SummerDressesPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
