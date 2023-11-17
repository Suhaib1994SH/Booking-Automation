using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace booking.pages
{
    internal static class MainPage
    {

        

        static ChromeDriver driver;
        public static void initDriver(ChromeDriver newDriver)
        {
            driver = newDriver;
        }

        /// <summary>
        /// navigate To Main Page
        /// </summary>
        public static void navigateToMainPage()
        {
            driver.Navigate().GoToUrl("https://www.booking.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// fill the distnations
        /// </summary>
        /// <param name="destName"></param>
        public static void fillDestName(string destName)
        {


            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                wait.Until(d => (bool)(driver.FindElement(By.XPath("//*[@aria-label='Dismiss sign-in info.']"))).Displayed);
                driver.FindElement(By.XPath("//*[@aria-label='Dismiss sign-in info.']")).Click();
            }
            catch
            {
            }
            commonFunctions.waitInSeconds(1);
            WebElement element = (WebElement)driver.FindElement(By.Id(":re:"));
            element.SendKeys(destName);
            commonFunctions.waitInSeconds(1);
            driver.FindElement(By.Id("autocomplete-result-0")).Click();

        }

        /// <summary> 
        /// fill Frst & End Dates
        /// </summary>
        /// <param name="FrstD"></param>
        /// <param name="EndD"></param>
        public static void fillFrstEndDates(string FrstD, string EndD)
        {
            commonFunctions.waitInSeconds(1);
            driver.FindElement(By.XPath("//*[@data-date='" + FrstD + "']")).Click();
            commonFunctions.waitInSeconds(1);
            driver.FindElement(By.XPath("//*[@data-date='" + EndD + "']")).Click();
            commonFunctions.waitInSeconds(1);


        }

        /// <summary>
        /// click on Search button
        /// </summary>
        public static void clickSearch()
        {
            driver.FindElement(By.XPath("//*[@type='submit']")).Click();
        }
    }
}
