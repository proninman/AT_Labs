using NUnitTestProject_Demo.business_object;
using NUnitTestProject_Demo.page_object;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace NUnitTestProject_Demo.service
{
    class CreateNewTestProduct
    {
        public static string CreateProduct(Product testproduct, IWebDriver driver)
        {
            AllProducts allproductspage = new AllProducts(driver);
            NewProductPage newproductpage = new NewProductPage(driver);
            HomePage homepage = new HomePage(driver);
            homepage.GoToAllProducts();
            allproductspage.GoToNewProduct();
            newproductpage.CreateProduct(testproduct);
            return allproductspage.H2AllProductsText();
        }
    }
}
