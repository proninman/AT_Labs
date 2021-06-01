using NUnit.Framework;
using OpenQA.Selenium;

using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace NUnitTest2
{
    class CreateNew : AbstractPage
    {
        public CreateNew(IWebDriver driver)
        {
            this.driver = driver;
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "ProductName")]
        private IWebElement prod_name;
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'Beverages')]")]
        private IWebElement CategoryId;
        [FindsBy(How = How.XPath, Using = "//option[contains(text(),'Pavlova, Ltd.')]")]
        private IWebElement SupplierId;
        [FindsBy(How = How.Id, Using = "UnitPrice")]
        private IWebElement unitPrice_id;
        [FindsBy(How = How.Id, Using = "QuantityPerUnit")]
        private IWebElement quantityPerUnit_id;
        [FindsBy(How = How.Id, Using = "UnitsInStock")]
        private IWebElement unitsInStock_id;
        [FindsBy(How = How.Id, Using = "UnitsOnOrder")]
        private IWebElement unitsOnOrder_id;
        [FindsBy(How = How.Id, Using = "ReorderLevel")]
        private IWebElement reorderLevel_id;
        [FindsBy(How = How.XPath, Using = "//*[@type='submit']")]
        private IWebElement submit;
        public CreateNew AddPrdt()
        {
            prod_name.SendKeys("Vodka");
            CategoryId.Click();
            SupplierId.Click();
            unitPrice_id.SendKeys("30");
            quantityPerUnit_id.SendKeys("1 l bottles");
            unitsInStock_id.SendKeys("26");
            unitsOnOrder_id.SendKeys("74");
            reorderLevel_id.SendKeys("25");
            submit.Click();
            return new CreateNew(driver);
        }

    }
}
