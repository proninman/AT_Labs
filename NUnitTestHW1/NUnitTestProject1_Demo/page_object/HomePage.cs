using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject_Demo.page_object
{
    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement H2FieldHomePage => driver.FindElement(By.XPath("//h2"));

        private IWebElement allProductsButton => driver.FindElement(By.LinkText("All Products"));

        public string H2HomePageText()
        {
            return H2FieldHomePage.Text;
        }

        public void GoToAllProducts()
        {
            new Actions(driver).MoveToElement(allProductsButton).Click(allProductsButton).Build().Perform();
        }

    }
}
