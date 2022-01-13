using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationPractice.Page_Objects
{
    class OrderPage : Header
    {
        public OrderPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
