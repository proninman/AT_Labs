using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace NUnitTestHW1
{

    
    public class Tests
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();
            IWebElement login = driver.FindElement(By.XPath("//input[@id='Name']"));
            login.SendKeys("user");
            IWebElement pass = driver.FindElement(By.XPath("//input[@id='Password']"));
            pass.SendKeys("user");
            IWebElement submit = driver.FindElement(By.XPath("//input[@type='submit']"));   
            submit.Click();  
            

        }

        [Test]
       public void Test1()
        {
            IWebElement assert_login = driver.FindElement(By.XPath("//*[contains(text(), 'Logout')]"));
            Assert.AreEqual("Logout", assert_login.Text);
         
        }

        [Test]
        public void Test2()
        {
            
            IWebElement all_prod = driver.FindElement(By.XPath("//a[contains(@href, '/Product')]"));
            all_prod.Click();
            IWebElement create_new = driver.FindElement(By.XPath("//a[contains(.,'Create new')]"));
            create_new.Click();
            IWebElement prod_name = driver.FindElement(By.Id("ProductName"));
            prod_name.SendKeys("Vodka");
            new SelectElement(driver.FindElement(By.Id("CategoryId"))).SelectByText("Beverages");
            new SelectElement(driver.FindElement(By.Id("SupplierId"))).SelectByText("Pavlova, Ltd.");
            IWebElement unitPrice_id = driver.FindElement(By.Id("UnitPrice"));
            unitPrice_id.SendKeys("30");
            IWebElement quantityPerUnit_id = driver.FindElement(By.Id("QuantityPerUnit"));
            quantityPerUnit_id.SendKeys("1 l bottles");
            IWebElement unitsInStock_id = driver.FindElement(By.Id("UnitsInStock"));
            unitsInStock_id.SendKeys("26");
            IWebElement unitsOnOrder_id = driver.FindElement(By.Id("UnitsOnOrder"));
            unitsOnOrder_id.SendKeys("74");
            IWebElement reorderLevel_id = driver.FindElement(By.Id("ReorderLevel"));
            reorderLevel_id.SendKeys("25");
            IWebElement submit = driver.FindElement(By.XPath("//*[@type='submit']"));
            submit.Click();
            IWebElement assert_var = driver.FindElement(By.XPath("//*[contains(text(), 'Vodka')]"));
            Assert.AreEqual("Vodka", assert_var.Text);


        }


        [Test]
       public void Test3()
        {
            
            IWebElement all_prod = driver.FindElement(By.XPath("//a[contains(@href, '/Product')]"));
            all_prod.Click();
            IWebElement prod_vodka = driver.FindElement(By.XPath("//a[contains(text(),'Vodka')][1]"));
            prod_vodka.Click();
           
            IWebElement prod_name = driver.FindElement(By.Id("ProductName"));
            Assert .AreEqual("Vodka",prod_name.GetAttribute("value"));

            IWebElement category_id = driver.FindElement(By.Id("CategoryId"));
            Assert.IsTrue(category_id.Text.Contains("Beverages"));
            IWebElement supplier_id = driver.FindElement(By.Id("SupplierId"));
            Assert.IsTrue(supplier_id.Text.Contains("Pavlova, Ltd."));
            IWebElement unitPrice_id = driver.FindElement(By.Id("UnitPrice"));
            Assert.AreEqual("30,0000", unitPrice_id.GetAttribute("value"));

            IWebElement quantityPerUnit_id = driver.FindElement(By.Id("QuantityPerUnit"));
            Assert.AreEqual("1 l bottles", quantityPerUnit_id.GetAttribute("value"));
            IWebElement unitsInStock_id = driver.FindElement(By.Id("UnitsInStock"));
            Assert.AreEqual("26",unitsInStock_id.GetAttribute("value"));
            IWebElement unitsOnOrder_id = driver.FindElement(By.Id("UnitsOnOrder"));
            Assert.AreEqual("74",unitsOnOrder_id.GetAttribute("value"));
            IWebElement reorderLevel_id = driver.FindElement(By.Id("ReorderLevel"));
            Assert.AreEqual("25",reorderLevel_id.GetAttribute("value"));
            
            IWebElement submit = driver.FindElement(By.XPath("//*[@type='submit']"));
            submit.Click();

        }


        [Test]
        public void Test4()
        {
            
            IWebElement all_prod = driver.FindElement(By.XPath("//a[contains(@href, '/Product')]"));
            all_prod.Click();
            IWebElement remove_lust_prod = driver.FindElement(By.XPath("(//a[contains(text(),'Remove')])[last()]"));
            remove_lust_prod.Click();
            driver.SwitchTo().Alert().Accept();
            IWebElement assert_login = driver.FindElement(By.XPath("//*[contains(text(), 'Vodka')]"));
            Assert.AreEqual("Vodka", assert_login.Text);

        }

        [Test]
        public void Test5()
        {

            IWebElement all_prod = driver.FindElement(By.XPath(" //a[contains(text(),'Logout')]"));
            all_prod.Click();
            IWebElement assert_var = driver.FindElement(By.XPath("//*[contains(text(), 'Login')]"));
            Assert.AreEqual("Login", assert_var.Text);


        }



        public static IWebDriver driver1;
        public static Boolean isElementPresent( By locator)
        {
           try
            {
                driver1.FindElement(locator);
            }
            catch (NoSuchElementException)
            {
                return false;

            }
            return true;
        }


        public void TearDown()
        {
          driver.Quit();
        }


    }

    


}