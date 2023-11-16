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

  
    internal static  class SearchResultsPage
    {

        static ChromeDriver driver;
        public static void initDriver(ChromeDriver newDriver)
        {
            driver = newDriver;
        }

        public static void clickOnSeeAvalibblty()
        {
            Thread.Sleep((int)1000);
            driver.FindElements(By.XPath("//*[@data-testid='availability-cta-btn']"))[0].Click(); 
        }
            public static void verifyBookingData()
        {
            Thread.Sleep((int)1000);
            driver.FindElement(By.XPath("//*[@type='submit']")).Click();
        }




    }


   
}
