using OpenQA.Selenium;
using ReqnrollProject1.Support;


namespace ReqnrollProject1.Pages
{
    public class LoginPage
    {
        IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement User => driver.FindElement(By.Id("user-name"));
        private IWebElement Pass => driver.FindElement(By.Id("password"));
        private IWebElement LoginBtn => driver.FindElement(By.Id("login-button"));
      


        public string GetUrl()
        {
            return DemoUrl.sauceDemoUrl; 
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

        public void EnterCredtialwithData(string u, string p)
        {
            User.SendKeys(u);
            Pass.SendKeys(p);
        }

        public void ClickLoginbtn()
        {
            LoginBtn.Click();
        }
    }
}
