using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll.BoDi;
using ReqnrollProject1.Model;
using ReqnrollProject1.Pages;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]

    public class LoginStepDefinitions
    {
        LoginPage lpage;
        ProductPage ppage;
        CartPage cartPage;
        CheckoutPage checkoutPage;
        CheckOutOverviewPage COverviewPage;
       
        IWebDriver driver;
        public LoginStepDefinitions(IObjectContainer container)
        {
            driver = container.Resolve<IWebDriver>();
            lpage = new LoginPage(driver);
            ppage = new ProductPage(driver);
            cartPage = new CartPage(driver);
            checkoutPage = new CheckoutPage(driver);
            COverviewPage = new CheckOutOverviewPage(driver);
        }

        [Given("I have accessed the Swag Labs Login Page")]
        public void GivenIHaveAccessedTheSwagLabsLoginPage()
      
        {   
            Assert.That(driver.Url.Contains(lpage.GetUrl()));
        }

        [When("I enter a {string} UserName and {string} Password")]
        public void WhenIEnterAUserNameAndPassword(string user, string pass)
        {
        
                lpage.EnterUserNameAndPassword(user,pass);
        }

        [When("I enter the login username and password details")]
        public void WhenIEnterTheLoginUsernameAndPasswordDetails()
        {
            lpage.EnterCredtialwithData(Data.Parameters.USER.Userdetails, Data.Parameters.USER.PasswordDetails);
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
            ppage.AddProductinCarts(dataTable.Rows[0]["product1"],dataTable.Rows[0]["product2"]);
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

        [When("I add the following products")]
        public void WhenIAddTheFollowingProducts(DataTable dataTable)
        {
            cartPage.AddTwoItemToCart(dataTable);
        }

        [Then("I Click Checkout Button")]
        public void ThenIClickCheckoutButton()
        {
            cartPage.ClickCheckOutBtn();
        }

        [Then("Confirm i am on the Checkout Page")]
        public void ThenConfirmIAmOnTheCheckoutPage()
        {
            Assert.That(checkoutPage.IsCheckoutTitleHeaderDisplayed(), Is.EqualTo(true), "Not Displayed");
        }

        [Then("I Enter the Checkout Information")]
        public void ThenIEnterTheCheckoutInformation(DataTable dataTable)
        {
            checkoutPage.FillCustomersFormDetails(dataTable.Rows[0]["FNAME"], dataTable.Rows[0]["LNAME"], dataTable.Rows[0]["ZIPCODE"]);
        }

        [Then("Click On the Continue Button")]
        public void ThenClickOnTheContinueButton()
        {
            checkoutPage.ClickContinueBtn();
        }

        [Then("Confirm I am on Checkout Overview Page")]
        public void ThenConfirmIAmOnCheckoutOverviewPage()
        {
            Assert.That(COverviewPage.IsCheckoutOverviewHeaderDisplayed(), Is.EqualTo(true), "Not Displayed");
        }

        [Then("Confirm the total number of products in the Checkout is {int}")]
        public void ThenConfirmTheTotalNumberOfProductsInTheCheckoutIs(int Expectedcount)
        {
            int actualCount = COverviewPage.GetProductCounts();
            Assert.That(actualCount, Is.EqualTo(Expectedcount), $"Product count in the basket is not {Expectedcount}. Actual: {actualCount}");
        }

        [Then("Click Finish Button")]
        public void ThenClickFinishButton()
        {
            COverviewPage.ClickFinishBtn();
        }

        [Then("Confirm the Order is Complete")]
        public void ThenConfirmTheOrderIsComplete()
        {
            Assert.That(COverviewPage.IsCheckoutOverviewHeaderDisplayed(), Is.EqualTo(true), "Not Displayed");
        }

        [Then("Logout.")]
        public void ThenLogout_()
        {
            ppage.ClickMenuAndLogout();
        }
       

    }
}
