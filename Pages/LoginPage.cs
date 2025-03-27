using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ReqnrollProject1.Support;
using static OpenQA.Selenium.BiDi.Modules.Script.RemoteValue.WindowProxy;


namespace ReqnrollProject1.Pages
{
    public class LoginPage
    {
       
        
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement User => driver.FindElement(By.Id("user-name"));
        private IWebElement Pass => driver.FindElement(By.Id("password"));
        private IWebElement LoginBtn => driver.FindElement(By.Id("login-button"));

        public string sauceDemoUrl { get; set; }

        public void NavigateToSite()
        {
           sauceDemoUrl = DemoUrl.sauceDemoUrl;

        }
        public void EnterUserNameAndPassword(string username, string pass)
        { 
            {
                User.SendKeys(username);
                Pass.SendKeys(pass); 
            }  
        }

        public void ValidCredential(string user,string pass)
        {
            User.SendKeys(user);
            Pass.SendKeys(pass);
        }

        public void ClickLoginbtn()
        {
            LoginBtn.Click();
        }
    }
}
