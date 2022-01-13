using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AutomationPractice.Page_Objects
{
    class Header
    {
        protected IWebDriver _driver;
        private By _headerBanner = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/blockbanner/img/sale70.png')]");
        private By _contactUs = By.LinkText("Contact us");
        private By _signIn = By.LinkText("Sign in");
        private By _logo = By.CssSelector(".logo");
        private By _searchQuery = By.Id("search_query_top");
        private By _cartButton = By.XPath("//div[3]/div/a");
        private By _dropTheWomen = By.XPath("//a[contains(text(),'Women')]");
        private By _topCategory = By.XPath("//a[contains(text(),'Tops')]");
        private By _tShirtsCategory = By.XPath("//a[contains(text(),'T-shirts')]");
        private By _blousesCategory = By.XPath("//a[contains(text(),'Blouses')]");
        private By _dressesCategory = By.XPath("//a[contains(text(),'Dresses')]");
        private By _casualDressesCategory = By.XPath("//a[contains(text(),'Casual Dresses')]");
        private By _eveningDressesCategory = By.XPath("//a[contains(text(),'Evening Dresses')]");
        private By _summerDressesCategory = By.XPath("//a[contains(text(),'Summer Dresses')]");
        private By _dropTheDress = By.XPath("//div[6]/ul/li[2]/a");
        private By _casualDressesCategoryDrop = By.XPath("//div[6]/ul/li[2]/ul/li/a");
        private By _eveningDressesCategoryDrop = By.XPath("//div[6]/ul/li[2]/ul/li[2]/a");
        private By _summerDressesCategoryDrop = By.XPath("//div[6]/ul/li[2]/ul/li[3]/a");
        private By _dropThetShirt = By.XPath("//div[6]/ul/li[3]/a");
        private By _searchButton = By.Name("submit_search");

        public Header HeaderBannerClick()
        {
            _driver.FindElement(_headerBanner).Click();
            return this;
        }

        public ContactPage ContactUsClick()
        {
            _driver.FindElement(_contactUs).Click();
            return new ContactPage(_driver);
        }

        public SignInPage SignInClick()
        {
            _driver.FindElement(_signIn).Click();
            return new SignInPage(_driver);
        }

        public Header LogoClick()
        {
            _driver.FindElement(_logo).Click();
            return this;
        }

        public Header SearchQueryAddText(string query)
        {
            _driver.FindElement(_searchQuery).SendKeys(query);
            return this;
        }

        public SearchResultPage SearchQueryEnter()
        {
            _driver.FindElement(_searchQuery).SendKeys("aboba");
            return new SearchResultPage(_driver);
        }

        public OrderPage CartButtonClick()
        {
            _driver.FindElement(_cartButton).Click();
            return new OrderPage(_driver);
        }

        public Header DropDownWomen()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropTheWomen);
            act.MoveToElement(elem).Perform();
            return this;
        }

        public TopsPage TopClick()
        {
            _driver.FindElement(_topCategory).Click();
            return new TopsPage(_driver);
        }

        public WomenPage WomenClick()
        {
            _driver.FindElement(_dropTheWomen).Click();
            return new WomenPage(_driver);
        }

        public TShirtsPage TShirtClick()
        {
            _driver.FindElement(_tShirtsCategory).Click();
            return new TShirtsPage(_driver);
        }

        public BlousesPage BlousesClick()
        {
            _driver.FindElement(_blousesCategory).Click();
            return new BlousesPage(_driver);
        }

        public DressesPage DressesClick()
        {
            _driver.FindElement(_dressesCategory).Click();
            return new DressesPage(_driver);
        }

        public CasualDressesPage CasualDressesClick()
        {
            _driver.FindElement(_casualDressesCategory).Click();
            return new CasualDressesPage(_driver);
        }

        public EveningDressesPage EveningDressesClick()
        {
            _driver.FindElement(_eveningDressesCategory).Click();
            return new EveningDressesPage(_driver);
        }

        public SummerDressesPage SummerDressesClick()
        {
            _driver.FindElement(_summerDressesCategory).Click();
            return new SummerDressesPage(_driver);
        }

        public DressesPage DropDressesClick()
        {
            _driver.FindElement(_dropTheDress).Click();
            return new DressesPage(_driver);
        }

        public Header DropDownDresses()
        {
            Actions act = new Actions(_driver);
            IWebElement elem = _driver.FindElement(_dropTheDress);
            act.MoveToElement(elem).Perform();
            return this;
        }

        public SummerDressesPage SummerDressesFromDropClick()
        {
            _driver.FindElement(_summerDressesCategoryDrop).Click();
            return new SummerDressesPage(_driver);
        }

        public CasualDressesPage CasualDressesFromDropClick()
        {
            _driver.FindElement(_casualDressesCategoryDrop).Click();
            return new CasualDressesPage(_driver);
        }

        public EveningDressesPage EveningDressesFromDropClick()
        {
            _driver.FindElement(_eveningDressesCategoryDrop).Click();
            return new EveningDressesPage(_driver);
        }

        public TShirtsPage DropShirtsClick()
        {
            _driver.FindElement(_dropThetShirt).Click();
            return new TShirtsPage(_driver);
        }

        public SearchResultPage SearchButtonClick()
        {
            _driver.FindElement(_searchButton).Click();
            return new SearchResultPage(_driver);
        }
    }
}
