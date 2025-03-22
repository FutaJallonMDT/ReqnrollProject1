using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ReqnrollProject1.Pages
{
    public class ProductPage
    {
        IWebDriver driver;
        public ProductPage(IWebDriver driver)
        {
           this.driver = driver;
        }


        private IWebElement productHeader => driver.FindElement(By.XPath("//span[@data-test='title']"));

        public bool IsproductHeaderDisplayed() => productHeader.Displayed;
    }
}
