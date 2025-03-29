using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ReqnrollProject1.Support;

namespace ReqnrollProject1.Drivers
{
    public class SpecDriver
    {      
        public IWebDriver driver;
        ChromeOptions options = new ChromeOptions();
        public void InitializedDriver() => driver = StartBrowser();

        private IWebDriver StartBrowser()
        {
            options.AddArguments("--start-maximized");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl(DemoUrl.sauceDemoUrl);
            return driver;
        }
        public void CloseBrowser()
        {
            driver.Quit();
        }

    }
}
