using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Firefox;

namespace NUnitTestProject_Demo.page_object
{
    class EditProduct : ProductPage
    {

        public EditProduct(IWebDriver driver) : base(driver)
        {
        }
        

        private IWebElement CategoryIdField => driver.FindElement(By.XPath("//*[@class='col - md - 4 form - group']//*[text()='Beverages']"));
       
         private IWebElement SupplierIdField => driver.FindElement(By.XPath("//*[@id='SupplierId']/option[12]"));


        //private IWebElement SupplierIdField => driver.FindElement(By.XPath("//*[@class='col - md - 4 form - group']//*[text()='Pavlova, Ltd.']"));

        //  private IWebElement SupplierIdField => driver.FindElement(By.XPath("//*[text()='Pavlova, Ltd.']"));
        //  private IWebElement SupplierIdField => driver.FindElement(By.XPath("//*[@id=\"SupplierId\"]/option[contains('Pavl')]"));

        private IWebElement ProductsButton => driver.FindElement(By.XPath("//a[contains(@href, '/Product')]"));
        // (By.XPath("//a[contains(@href, '/Product')]"));
        // private IWebElement ProductsButton => driver.FindElement(By.XPath("//*[@href=\"/Product\"]"));

        public string ProductName()
        {
            return ProductNameField.GetAttribute("value");
        }

        public string CategoryID()
        {
            return CategoryIdField.Text;
        }

        public string SupplierID()
        {
            return SupplierIdField.Text;
        }

        public string UnitPrice()
        {
            return UnitPriceField.GetAttribute("value");
        }

        public string QuantityPerUnit()
        {
            return QuantityPerUnitField.GetAttribute("value");
        }

        public string UnitsInStock()
        {
            return UnitsInStockField.GetAttribute("value");
        }

        public string UnitsOnOrder()
        {
            return UnitsOnOrderField.GetAttribute("value");
        }

        public string ReorderLevel()
        {
            return ReorderLevelField.GetAttribute("value");
        }

     //   public string Discontinued()
     //   {
     //       return DiscontinuedField.GetAttribute("checked");
     //   }

        public void GoToProducts()
        {
            new Actions(driver).Click(ProductsButton).Build().Perform();
        }
    }
}
