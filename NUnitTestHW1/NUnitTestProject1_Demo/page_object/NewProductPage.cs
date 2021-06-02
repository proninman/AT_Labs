using NUnitTestProject_Demo.business_object;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject_Demo.page_object
{
    class NewProductPage : ProductPage
    {

        public NewProductPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        private IWebElement CategoryIdField => driver.FindElement(By.Id("CategoryId"));

        private IWebElement SupplierIdField => driver.FindElement(By.Id("SupplierId"));

        private IWebElement SendButton => driver.FindElement(By.CssSelector(".btn"));


        public void CreateProduct(Product testproduct)
        {
            new Actions(driver).SendKeys(ProductNameField, testproduct.ProductName).Build().Perform();
            new Actions(driver).SendKeys(CategoryIdField, testproduct.CategoryId).Build().Perform();
            new Actions(driver).SendKeys(SupplierIdField, testproduct.SupplierId).Build().Perform();
            new Actions(driver).SendKeys(UnitPriceField, testproduct.UnitPrice).Build().Perform();
            new Actions(driver).SendKeys(QuantityPerUnitField, testproduct.QuantityPerUnit).Build().Perform();
            new Actions(driver).SendKeys(UnitsInStockField, testproduct.UnitsInStock).Build().Perform();
            new Actions(driver).SendKeys(UnitsOnOrderField, testproduct.UnitsOnOrder).Build().Perform();
            new Actions(driver).SendKeys(ReorderLevelField, testproduct.ReorderLevel).Build().Perform();
         
            new Actions(driver).Click(SendButton).Build().Perform();
        }
    }
}
