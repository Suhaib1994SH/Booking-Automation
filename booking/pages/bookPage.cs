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

        /// <summary>
        /// fill the Booking Details firstname , lastname ,  email , phone
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="Email"></param>
        /// <param name="Phone"></param>
        public static void fillBookingDetails(string firstName, string lastName, string Email, string Phone)
        {
            commonFunctions.waitInSeconds(1);
            driver.FindElement(By.Id("firstname")).SendKeys(firstName);
            commonFunctions.waitInSeconds(1);
            driver.FindElement(By.Id("lastname")).SendKeys(lastName);
            commonFunctions.waitInSeconds(1);
            driver.FindElement(By.Id("email")).SendKeys(Email);
            commonFunctions.waitInSeconds(1);
            driver.FindElement(By.XPath("//*[@data-email='suhaib.fts@gmail.com']")).Click();
            commonFunctions.waitInSeconds(1);
            driver.FindElement(By.Id("phone")).SendKeys(Phone);
            commonFunctions.waitInSeconds(1);
            driver.FindElement(By.XPath("//*[@data-popover-content-id='bp-submit-popover']")).Click();
            commonFunctions.waitInSeconds(1);
        }

        /// <summary>
        /// fill the Payment Details Card Number , card Expiratio Date , CVC Number
        /// </summary>
        /// <param name="CardNumber"></param>
        /// <param name="cardExpiratioDate"></param>
        /// <param name="CVCNumber"></param>
        public static void fillPaymentDetails(string CardNumber,string cardExpiratioDate, string CVCNumber)
        {
            driver.SwitchTo().Frame(driver.FindElement(By.CssSelector("#bookForm > div.payment-section > div.payment-instrument-section.bui-spacer--large > div > div > div > div:nth-child(2) > div > div:nth-child(2) > iframe")));
            commonFunctions.waitInSeconds(1);
            ScrollInPixel("1000");
            driver.FindElement(By.Id("P0-0")).SendKeys(" 1");
            commonFunctions.waitInSeconds(1);
            driver.FindElements(By.ClassName("YyPS4CCyBc09wPIEDhf6"))[1].SendKeys( CardNumber);
            commonFunctions.waitInSeconds(1);
            driver.FindElements(By.ClassName("YyPS4CCyBc09wPIEDhf6"))[3].SendKeys(cardExpiratioDate);
            commonFunctions.waitInSeconds(1);
            driver.FindElement(By.Id("P0-1")).SendKeys(CVCNumber);
            commonFunctions.waitInSeconds(1);
            ScrollInPixel("1000");
            driver.SwitchTo().ParentFrame();
            driver.FindElement(By.CssSelector("#bookForm > div.bui-group.bui-spacer--large > div > div:nth-child(3) > button")).Click();
            commonFunctions.waitInSeconds(1);

        }
    }
}
