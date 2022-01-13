using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AutomationPractice.Page_Objects;

namespace AutomationPractice
{
    public class UnitTest1 : BaseTest
    {
        IWebDriver chrome;
        [Fact]
        public void Test1()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.HeaderBannerClick()
                .ContactUsClick();
        }

        [Fact]
        public void Test2()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.SignInClick();
        }

        [Fact]
        public void Test3()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.SearchQueryAddText("sample text")
                .SearchQueryEnter();
        }

        [Fact]
        public void Test4()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.LogoClick();
                
        }

        [Fact]
        public void Test5()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.CartButtonClick();

        }

        [Fact]
        public void Test6()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.DropDownWomen()
                .TopClick();

        }

        [Fact]
        public void Test7()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.WomenClick();

        }

        [Fact]
        public void Test8()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.DropDownWomen()
                .TShirtClick();

        }

        [Fact]
        public void Test9()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.DropDownWomen()
                .BlousesClick();

        }

        [Fact]
        public void Test10()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.DropDownWomen()
                .DressesClick();

        }

        [Fact]
        public void Test11()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.DropDownWomen()
                .CasualDressesClick();

        }

        [Fact]
        public void Test12()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.DropDownWomen()
                .EveningDressesClick();

        }

        [Fact]
        public void Test13()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.DropDownWomen()
                .SummerDressesClick();

        }

        [Fact]
        public void Test14()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.DropDressesClick();

        }

        [Fact]
        public void Test15()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.DropDownDresses()
                .CasualDressesFromDropClick();

        }

        [Fact]
        public void Test16()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.DropDownDresses()
                .EveningDressesFromDropClick();

        }

        [Fact]
        public void Test17()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.DropDownDresses()
                .SummerDressesFromDropClick();

        }

        [Fact]
        public void Test18()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.DropShirtsClick();

        }

        [Fact]
        public void Test19()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.DropDownWomen();

        }

        [Fact]
        public void Test20()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.DropDownDresses();

        }

        [Fact]
        public void Test21()
        {
            chrome = StartDriverWithURL("http://automationpractice.com/index.php");
            Header homePage = new HomePage(chrome);
            homePage.SearchQueryAddText("sample text")
                 .SearchButtonClick();

        }
    }
}
