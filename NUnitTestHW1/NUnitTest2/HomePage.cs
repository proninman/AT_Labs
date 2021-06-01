using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace NUnitTest2
{
    class HomePage : AbstractPage
    {
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'All Products')])[2]")]
        private IWebElement all_prod;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Logout')]")]
        private IWebElement logout;

        public void Logout()
        {
            Assert.AreEqual("Logout", logout.Text);
        }
        public AllProducts Click()
        {
            all_prod.Click();
            return new AllProducts(driver);
        }
        public void LogOut()
        {
            logout.Click();
        }
    }
}
