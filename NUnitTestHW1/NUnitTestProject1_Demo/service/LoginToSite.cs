using NUnitTestProject_Demo.business_object;
using NUnitTestProject_Demo.page_object;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace NUnitTestProject_Demo.service
{
    class LoginToSite
    {

        public static string UserLogin(TestUser testuser, IWebDriver driver)
        {
            LoginPage loginpage = new LoginPage(driver);
            HomePage homepage = new HomePage(driver);
            loginpage.Login(testuser);
            return homepage.H2HomePageText();
        }



    }
}
