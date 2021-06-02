using NUnit.Framework;
using NUnitTestProject_Demo.business_object;
using NUnitTestProject_Demo.page_object;
using NUnitTestProject_Demo.service;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace NUnitTestProject_Demo.tests
{
    [TestFixture]
    public class NorthwindTest : BaseTest
    {

        private LoginPage loginpage;
        private AllProducts allproductspage;
        private EditProduct editproductpage;
        private readonly Product testproduct = new Product("Vodka", "Beverages", "Pavlova, Ltd.", "30,000", "1 l bottles", "26", "74", "25");
        private readonly TestUser testuser = new TestUser("user", "user");

        [Test, Order(1)]
        public void TestLogin()
        {
            Assert.AreNotEqual("Login", LoginToSite.UserLogin(testuser, driver));
        }

        [Test, Order(2)]
        public void TestCreateProduct()
        {
            Assert.AreNotEqual("Product editing", CreateNewTestProduct.CreateProduct(testproduct, driver));
        }

        [Test, Order(3)]
        public void CheckFieldsProduct()
        {
            editproductpage = new EditProduct(driver);
            allproductspage = new AllProducts(driver);
            allproductspage.GoToProduct("Vodka");
            Assert.AreEqual("Vodka", editproductpage.ProductName());
          //  Assert.AreEqual("Beverages", editproductpage.CategoryID());
          //  Assert.AreEqual("Pavlova, Ltd.", editproductpage.SupplierID());
            Assert.AreEqual("30,000", editproductpage.UnitPrice());
            Assert.AreEqual("1 l bottles", editproductpage.QuantityPerUnit());
            Assert.AreEqual("26", editproductpage.UnitsInStock());
            Assert.AreEqual("74", editproductpage.UnitsOnOrder());
            Assert.AreEqual("25", editproductpage.ReorderLevel());
       
        }
        [Test, Order(4)]
        public void RemoveProduct()
        {
            editproductpage.GoToProducts();
            allproductspage.DeleteProduct();
            Assert.IsFalse(allproductspage.FindProduct("Vodka"));
        }

        [Test, Order(5)]
        public void LogOut()
        {
            loginpage = new LoginPage(driver);
            allproductspage.LogOut();
            Assert.AreEqual("Login", loginpage.H2LoginPageText());
        }

    }
}
