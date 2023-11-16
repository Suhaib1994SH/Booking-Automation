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
    internal static class hotelPage
    {


        static ChromeDriver driver;
        public static void initDriver(ChromeDriver newDriver)
        {
            driver = newDriver;
        }

        public static void clickOnReserve()
        {
            Thread.Sleep((int)1000);
            driver.FindElement(By.Id("hp_book_now_button")).Click();
        }




        public static void clickOnConfirmReserve()
        {
            
            Thread.Sleep((int)1000);
            driver.FindElement(By.Id("hp_book_now_button")).Click();

        }
       
    }
}
