using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll.BoDi;
using ReqnrollProject1.Drivers;
using ReqnrollProject1.Model;
using ReqnrollProject1.Pages;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]

    public class LoginStepDefinitions
    {
        LoginPage lpage;
        ProductPage ppage;
        IWebDriver driver;
        public LoginStepDefinitions(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
            lpage = new LoginPage(driver);
            ppage = new ProductPage(driver);
        }

        [Given("I have accessed the Swag Labs Login Page")]
        public void GivenIHaveAccessedTheSwagLabsLoginPage()
        {
            lpage.NavigateToSite();
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

        [Then("I Add Two products to basket")]
        public void ThenIAddTwoProductsToBasket()
        {
            ppage.AddProductinCarts();
            Assert.That(ppage.IsSauceBackPackNameDisplayed(), Is.EqualTo(true));
            Assert.That(ppage.IsProductBikeNameDisplayed(),Is.EqualTo(true));
        }

        [Then("confirm the total number of products in the basket")]
        public void ThenConfirmTheTotalNumberOfProductsInTheBasket()
        {
            string productCount = ppage.getproductcountDisplayed();
            Assert.That(productCount, Is.EqualTo(productCount), "Product count in the basket is not 2.");

        }

        [Then("Logout.")]
        public void ThenLogout_()
        {
            ppage.ClickMenuAndLogout();
        }
       

    }
}
