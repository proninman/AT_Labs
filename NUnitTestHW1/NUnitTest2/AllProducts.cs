using NUnit.Framework;
using OpenQA.Selenium;

using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace NUnitTest2
{
    class AllProducts : AbstractPage
    {
        public AllProducts(IWebDriver driver)
        {
            this.driver = driver;
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Create new')]")]
        private IWebElement btncreatenew;
        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Vodka')])[1]")]
        private IWebElement prod_vodka;
        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Remove')])[last()]")]
        private IWebElement remove;

        public Product CheckAdd()
        {
            prod_vodka.Click();
            return new Product(driver);
        }

        public CreateNew ClickBtn()
        {
            btncreatenew.Click();
            return new CreateNew(driver);
        }
        public void CheckBtn()
        {
            Assert.AreEqual("Create new", btncreatenew.Text);
        }
        public AllProducts Remove()
        {
            remove.Click();
            driver.SwitchTo().Alert().Accept();
            Assert.IsTrue(driver.PageSource.Contains("Vodka"));
            return new AllProducts(driver);
        }
    }
}
