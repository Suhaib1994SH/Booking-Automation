using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace booking.pages
{
    public static class hotelPage
    {


        static ChromeDriver driver;
        public static void initDriver(ChromeDriver newDriver)
        {
            driver = newDriver;
        }

        /// <summary>
        /// click on Reserve button
        /// </summary>
        public static void clickOnReserve()
        {
            commonFunctions.waitInSeconds(1);
            driver.FindElement(By.Id("hp_book_now_button")).Click();
            
        }



        /// <summary>
        /// click on Confirm Reserve button
        /// </summary>
        public static void clickOnConfirmReserve()
        {

            commonFunctions.waitInSeconds(1);
            driver.FindElement(By.Id("hp_book_now_button")).Click();

        }
       
    }
}
