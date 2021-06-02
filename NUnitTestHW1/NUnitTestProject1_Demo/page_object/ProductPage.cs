using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject_Demo.page_object
{
    class ProductPage
    {
        private protected IWebDriver driver;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private protected IWebElement ProductNameField => driver.FindElement(By.Id("ProductName"));

        private protected IWebElement UnitPriceField => driver.FindElement(By.Id("UnitPrice"));

        private protected IWebElement QuantityPerUnitField => driver.FindElement(By.Id("QuantityPerUnit"));

        private protected IWebElement UnitsInStockField => driver.FindElement(By.Id("UnitsInStock"));

        private protected IWebElement UnitsOnOrderField => driver.FindElement(By.Id("UnitsOnOrder"));

        private protected IWebElement ReorderLevelField => driver.FindElement(By.Id("ReorderLevel"));

        
    }
}
