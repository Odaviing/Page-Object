using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationPractice.Page_Objects
{
    class EveningDressesPage : Header
    {
        public EveningDressesPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
