using NUnitTestProject_Demo.business_object;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;


namespace NUnitTestProject_Demo.page_object
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement name => driver.FindElement(By.Id("Name"));

        private IWebElement password => driver.FindElement(By.Id("Password"));

        private IWebElement submit => driver.FindElement(By.XPath("//input[@type='submit']"));

        private IWebElement H2FieldLoginPage => driver.FindElement(By.XPath("//h2"));

        public void Login(TestUser testuser)
        {
            new Actions(driver).SendKeys(name, testuser.Login).Build().Perform();
            new Actions(driver).SendKeys(password, testuser.Password).Build().Perform();
            new Actions(driver).MoveToElement(submit).Click(submit).Build().Perform();
        }

        public string H2LoginPageText()
        {
            return H2FieldLoginPage.Text;
        }
    }
}
