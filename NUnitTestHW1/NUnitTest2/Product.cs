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
    class Product : AbstractPage
    {
        public Product(IWebDriver driver)
        {
            this.driver = driver;
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//input[@id='ProductName']")]
        private IWebElement prod_name;
        [FindsBy(How = How.Id, Using = "CategoryId")]
        private IWebElement category;
        [FindsBy(How = How.XPath, Using = "//select[@id='SupplierId']")]
        private IWebElement supplier;
        [FindsBy(How = How.Id, Using = "UnitPrice")]
        private IWebElement unitPrice;
        [FindsBy(How = How.XPath, Using = "//input[@id='QuantityPerUnit']")]
        private IWebElement quantityPerUnit;
        [FindsBy(How = How.Id, Using = "UnitsInStock")]
        private IWebElement unitsInStock;
        [FindsBy(How = How.Id, Using = "UnitsOnOrder")]
        private IWebElement unitsOnOrder;
        [FindsBy(How = How.Id, Using = "ReorderLevel")]
        private IWebElement reorderLevel;
        public Product Check()
        {
            Assert.AreEqual("Vodka", prod_name.GetAttribute("value"));
            Assert.AreEqual("Beverages", category.Text);
            Assert.IsTrue(supplier.Text.Contains("Pavlova, Ltd."));
            Assert.AreEqual("30,0000", unitPrice.GetAttribute("value"));
            Assert.AreEqual("1 l bottles", quantityPerUnit.GetAttribute("value"));
            Assert.AreEqual("26", unitsInStock.GetAttribute("value"));
            Assert.AreEqual("74", unitsOnOrder.GetAttribute("value"));
            Assert.AreEqual("25", reorderLevel.GetAttribute("value"));
            return new Product(driver);
        }

    }
}
