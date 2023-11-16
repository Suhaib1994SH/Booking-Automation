using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace booking.pages
{
    internal static class bookPage
    {
        static ChromeDriver driver;
        public static void initDriver(ChromeDriver newDriver)
        {
            driver = newDriver;
        }

        /// <summary>
        /// Execute Java script
        /// </summary>
        /// <param name="Script"></param>
        public static void ExecuteJSScript(string Script)
        {
            (driver as IJavaScriptExecutor).ExecuteScript(Script);
        }

        /// <summary>
        /// Scroll in pexel 
        /// </summary>
        /// <param name="ScrollValue"></param>
        public static void ScrollInPixel(string ScrollValue)
        {
            ExecuteJSScript("window.scrollBy(0," + ScrollValue + ")");
        }

        public static void fillBookingDetails(string firstName, string lastName, string Email, string Phone)
        {

            driver.FindElement(By.Id("firstname")).SendKeys(firstName);
            Thread.Sleep((int)1000);
            driver.FindElement(By.Id("lastname")).SendKeys(lastName);
            Thread.Sleep((int)1000);
            driver.FindElement(By.Id("email")).SendKeys(Email);
            Thread.Sleep((int)1000);
            driver.FindElement(By.XPath("//*[@data-email='suhaib.fts@gmail.com']")).Click();
            Thread.Sleep((int)1000);

            driver.FindElement(By.Id("phone")).SendKeys(Phone);
            Thread.Sleep((int)1000);
            driver.FindElement(By.XPath("//*[@data-popover-content-id='bp-submit-popover']")).Click();
        }

        public static void fillPaymentDetails(string CardNumber,string cardExpiratioDate, string CVCNumber)
        {
            Thread.Sleep((int)1000);
            ScrollInPixel("1000");


            driver.FindElement(By.Id("P0-0")).SendKeys(" 1");
            driver.FindElements(By.ClassName("YyPS4CCyBc09wPIEDhf6"))[1].SendKeys( CardNumber);





            Thread.Sleep((int)1000);
            driver.FindElements(By.ClassName("YyPS4CCyBc09wPIEDhf6"))[3].SendKeys(cardExpiratioDate);
            Thread.Sleep((int)1000);
            driver.FindElement(By.Id("P0-1")).SendKeys(CVCNumber);
            Thread.Sleep((int)1000);
            ScrollInPixel("1000");
            driver.SwitchTo().ParentFrame();
            driver.FindElement(By.CssSelector("#bookForm > div.bui-group.bui-spacer--large > div > div:nth-child(3) > button")).Click();
            Thread.Sleep((int)1000);

        }
    }
}
