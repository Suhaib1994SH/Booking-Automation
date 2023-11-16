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

        /// <summary>
        /// wait in seconds
        /// </summary>
        /// <param name="waitInSeconds">value in seconds</param>

        public static void waitInSeconds(double waitInSeconds)
        {
            waitInSeconds = waitInSeconds * 1000;
            Thread.Sleep((int)waitInSeconds);
        }

        static ChromeDriver driver;
        public static void initDriver(ChromeDriver newDriver)
        {
            driver = newDriver;
        }
        public static void navigateToMainPage()
        {
            driver.Navigate().GoToUrl("https://www.booking.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
        }

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

            WebElement element = (WebElement)driver.FindElement(By.Id(":re:"));
            element.SendKeys(destName);
            waitInSeconds(1);
            driver.FindElement(By.Id("autocomplete-result-0")).Click();

        }
        public static void fillFrstEndDates(string FrstD, string EndD)
        {
            MainPage.waitInSeconds(1);
            driver.FindElement(By.XPath("//*[@data-date='" + FrstD + "']")).Click();
            MainPage.waitInSeconds(1);
            driver.FindElement(By.XPath("//*[@data-date='" + EndD + "']")).Click();
            MainPage.waitInSeconds(1);


        }
        public static void clickSearch()
        {
            driver.FindElement(By.XPath("//*[@type='submit']")).Click();
        }
    }
}
