using OpenQA.Selenium;

namespace ReqnrollProject1.Pages
{
    
    public class CheckOutOverviewPage
    {
        IWebDriver driver;

        public CheckOutOverviewPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement checkoutoverviewHeader => driver.FindElement(By.CssSelector("[class='title']"));
        private IWebElement FinishBtn => driver.FindElement(By.Id("finish"));
        private IReadOnlyCollection<IWebElement> productcounts => driver.FindElements(By.CssSelector("[data-test='inventory-item-name']"));
        public bool IsCheckoutOverviewHeaderDisplayed() => checkoutoverviewHeader.Displayed;

        public int GetProductCounts() => productcounts.Count;
        public void ClickFinishBtn() => FinishBtn.Click();
    }
}
