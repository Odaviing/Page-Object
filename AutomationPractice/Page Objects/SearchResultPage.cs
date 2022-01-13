using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationPractice.Page_Objects
{
    class SearchResultPage : Header
    {
        public SearchResultPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
