using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using Reqnroll.BoDi;
using ReqnrollProject1.Drivers;
using ReqnrollProject1.Model;
using ReqnrollProject1.Pages;
using ReqnrollProject1.Support;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]

    public class LoginStepDefinitions
    {
        LoginPage lpage;
        ProductPage ppage;
        CartPage cartPage;
       
        IWebDriver driver;
        public LoginStepDefinitions(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
            lpage = new LoginPage(driver);
            ppage = new ProductPage(driver);
            cartPage = new CartPage(driver);
        }

        [Given("I have accessed the Swag Labs Login Page")]
        public void GivenIHaveAccessedTheSwagLabsLoginPage()
        {
            lpage.NavigateToSite();
            Assert.That(driver.Url.Contains("https://www.saucedemo.com/"));
        }


        [When("I enter a {string} UserName and {string} Password")]
        public void WhenIEnterAUserNameAndPassword(string user, string pass)
        {
        
                lpage.EnterUserNameAndPassword(user,pass);
        }

        [When("I enter the Login Credential Details")]
        public void WhenIEnterTheLoginCredentialDetails(DataTable dataTable)
        {
            lpage.ValidCredential(
            dataTable.Rows[0]["username"], 
            dataTable.Rows[0]["password"]);
        }

        [When("I enter the Credential Details")]
        public void WhenIEnterTheCredentialDetails(DataTable dataTable)
        {
            var tableData = dataTable.CreateInstance<MyTableData>();
            lpage.EnterUserNameAndPassword(tableData.username, tableData.password);
        }

        [When("I Click Login Button")]
        public void WhenIClickLoginButton()
        {
            lpage.ClickLoginbtn();
        }

        [Then("I should Navigate to the Product Page")]
        public void ThenIShouldNavigateToTheProductPage()
        {

            Assert.That(ppage.IsproductHeaderDisplayed(), Is.EqualTo(true), "Not displayed");
        }

        [When("I Add Two products to baskets")]
        public void WhenIAddTwoProductsToBaskets(DataTable dataTable)
        {
            ppage.AddProductinCarts(
                dataTable.Rows[0]["product1"],
                dataTable.Rows[0]["product2"]);
        }

        [When("I Click on the Shopping Cart to view the Basket")]
        public void WhenIClickOnTheShoppingCartToViewTheBasket()
        {
            ppage.ViewBasket();
        }

        [Then("confirm the total number of products in the basket is {int}")]
        public void ThenConfirmTheTotalNumberOfProductsInTheBasketIs(int Expectedcount)
        {
            int actualCount = cartPage.GetProductCounts();
            Assert.That(actualCount, Is.EqualTo(Expectedcount), $"Product count in the basket is not {Expectedcount}. Actual: {actualCount}");
        }

        [Then("I Verify {int} Product Names in the baskets as")]
        public void ThenIVerifyProductNamesInTheBasketsAs(int p0, DataTable dataTable)
        {
          
            var product1 = dataTable.Rows[0]["product1"];
            var product2 = dataTable.Rows[0]["product2"];
            cartPage.GetProductNamesinCart(product1, product2);

        }

        [Then("Logout.")]
        public void ThenLogout_()
        {
            ppage.ClickMenuAndLogout();
        }
       

    }
}
