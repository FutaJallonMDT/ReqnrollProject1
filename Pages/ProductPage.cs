using OpenQA.Selenium;



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
        private IWebElement Productcount => driver.FindElement(By.CssSelector("[data-test='shopping-cart-badge']"));
        private IWebElement shopingCartBasket => driver.FindElement(By.CssSelector("[data-test='shopping-cart-link']"));
        private IWebElement BackPackproductName => driver.FindElement(By.XPath("//div[@class='inventory_item_name '][.='Sauce Labs Backpack']"));
        private IWebElement ProductBikeName => driver.FindElement(By.XPath("//div[@class='inventory_item_name '][.='Sauce Labs Bike Light']"));
        private IWebElement MenuIcon => driver.FindElement(By.Id("react-burger-menu-btn"));
        private IWebElement LogoutBtn => driver.FindElement(By.Id("logout_sidebar_link"));

        public string getproductcount() => Productcount.Text;
        public bool IsproductHeaderDisplayed() => productHeader.Displayed;
        public bool IsSauceBackPackNameDisplayed() => BackPackproductName.Displayed;
        public bool IsProductBikeNameDisplayed() => ProductBikeName.Displayed;

        public void ViewBasket() => shopingCartBasket.Click();
        public void AddProductinCarts(string p1, string p2)
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
