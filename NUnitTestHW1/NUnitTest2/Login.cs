using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;

namespace NUnitTest2
{
    class Login : AbstractPage
    {

        
        private WebDriverWait wait;
       
        // Thread.Sleep(20000);
      
        public Login(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "Name")]
        private IWebElement name;
        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement password;
        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement submit;
        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Logout')]")]
        private IWebElement assert_login;
        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Login')]")]
        private IWebElement assert_logout;


        public HomePage LogIn()
        {
            name.SendKeys("user");
            password.SendKeys("user");
            submit.Click();
            return new HomePage(driver);
        }
        public void Checkout()
        {
            Assert.AreEqual("Login", assert_logout.Text);
        }
        public void Checkin()
        {
            Assert.AreEqual("Logout", assert_login.Text);
        }

    }
}
