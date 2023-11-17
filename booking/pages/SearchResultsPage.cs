using OpenQA.Selenium;
using booking.pages;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace booking.pages
{


    internal static class SearchResultsPage 
    {

       static ChromeDriver driver;
        public static void initDriver(ChromeDriver newDriver)
        {
          driver = newDriver;
        }

        /// <summary>
        /// click on See Avalibblt button
        /// </summary>
        public static void clickOnSeeAvalibblty()
        {
            commonFunctions.waitInSeconds(1);
            driver.FindElements(By.XPath("//*[@data-testid='availability-cta-btn']"))[0].Click(); 
        }

        /// <summary>
        /// click on verify Booking Data
        /// </summary>
        public static void verifyBookingData()
        {
            commonFunctions.waitInSeconds(1);
            driver.FindElement(By.XPath("//*[@type='submit']")).Click();
        }




    }


   
}
