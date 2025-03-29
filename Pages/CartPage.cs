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

        public int GetProductCounts() => productcounts.Count;

        public void GetProductNamesinCart(string prod1, string prod2)
        {
            var prod1name = ProductNameDisplayed(prod1);
            var prod2name = ProductNameDisplayed(prod2);
        }
    }
}
