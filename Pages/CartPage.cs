using OpenQA.Selenium;

namespace ReqnrollProject1.Pages
{
    public class CartPage
    {
        IWebDriver driver;
        public CartPage(IWebDriver driver)
        {
           this.driver = driver;
        }
        private IWebElement ProductNameDisplayed(string Name) => driver.FindElement(By.XPath($"//div[text() = '{Name}']"));
        private IReadOnlyCollection<IWebElement> productcounts => driver.FindElements(By.CssSelector("[data-test='inventory-item-name']"));

        private IWebElement Addbackpack => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        private IWebElement AddbikeLight => driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));

        private IWebElement CheckoutBtn => driver.FindElement(By.Id("checkout"));

        public int GetProductCounts() => productcounts.Count;

        public void GetProductNamesinCart(string prod1, string prod2)
        {
            var prod1name = ProductNameDisplayed(prod1);
            var prod2name = ProductNameDisplayed(prod2);
        }

        public void AddTwoItemToCart(DataTable table)
        {
            Addbackpack.Click();
            AddbikeLight.Click();
        }

        public void ClickCheckOutBtn() => CheckoutBtn.Click();
    }
}
