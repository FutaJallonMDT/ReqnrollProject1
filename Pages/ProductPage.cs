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
        private IWebElement Addbackpack => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        private IWebElement AddbikeLight => driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        private IWebElement productCount => driver.FindElement(By.CssSelector("[data-test='shopping-cart-badge']"));
        private IWebElement BackPackproductName => driver.FindElement(By.XPath("//div[@class='inventory_item_name '][.='Sauce Labs Backpack']"));
        private IWebElement productBikeName => driver.FindElement(By.XPath("//div[@class='inventory_item_name '][.='Sauce Labs Bike Light']"));
        private IWebElement MenuIcon => driver.FindElement(By.Id("react-burger-menu-btn"));
        private IWebElement LogoutBtn => driver.FindElement(By.Id("logout_sidebar_link"));

        public string getproductcountDisplayed() => productCount.Text;
        public bool IsproductHeaderDisplayed() => productHeader.Displayed;
        public bool IsSauceBackPackNameDisplayed() => BackPackproductName.Displayed;
        public bool IsProductBikeNameDisplayed() => productBikeName.Displayed;

        public void AddProductinCarts()
        {
            Addbackpack.Click();
            AddbikeLight.Click();
        }

        public void ClickMenuAndLogout()
        {
            MenuIcon.Click();
            LogoutBtn.Click();
        }
    }
}
