using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollProject1.Pages
{
    public class CheckoutPage
    {
        IWebDriver driver;
        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        private IWebElement CheckoutTitleHeader => driver.FindElement(By.CssSelector("[class='title']"));
        private IWebElement FirstNameTxt => driver.FindElement(By.Id("first-name"));
        private IWebElement LastNameTxt => driver.FindElement(By.Id("last-name"));
        private IWebElement PostalCodeTxt => driver.FindElement(By.Id("postal-code"));
        private IWebElement ContinueBtn => driver.FindElement(By.Id("continue"));

        public bool IsCheckoutTitleHeaderDisplayed() => CheckoutTitleHeader.Displayed;
        public void ClickContinueBtn() => ContinueBtn.Click();

        public void FillCustomersFormDetails(string fname, string lname, string pcode)
        {
            FirstNameTxt.SendKeys(fname);
            LastNameTxt.SendKeys(lname);
            PostalCodeTxt.SendKeys(pcode);
        }


    }
}
