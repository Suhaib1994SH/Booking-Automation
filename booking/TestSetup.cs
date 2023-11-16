using booking.pages;
using booking;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;
using NUnit.Framework;

namespace booking
{

    internal class TestSetup
    {

       
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            MainPage.initDriver(driver);
            SearchResultsPage.initDriver(driver);
           
            MainPage.navigateToMainPage();
            List<Item> items = commonFunctions.LoadJson();


            MainPage.fillDestName(items[0].distnations[0]);

            // var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            //wait.Until(d => (bool)(driver.FindElement(By.XPath("//*[@data-testid='datepicker-tabs']"))).Displayed);

            MainPage.waitInSeconds(1);


            MainPage.fillFrstEndDates(items[0].start_date, items[0].end_date);

            MainPage.clickSearch();


            MainPage.waitInSeconds(1);
            SearchResultsPage.clickOnSeeAvalibblty();

            driver.SwitchTo().Window(driver.WindowHandles.Last());

            hotelPage.initDriver(driver);

            MainPage.waitInSeconds(1);
            hotelPage.clickOnReserve();
            MainPage.waitInSeconds(1);
            hotelPage.clickOnConfirmReserve();
            bookPage.initDriver(driver);
            bookPage.fillBookingDetails(items[0].firstname, items[0].lastname, items[0].email, items[0].phone);
            MainPage.waitInSeconds(5);

            //driver.SwitchTo().Window(driver.WindowHandles.Last());
            //driver.Navigate().Refresh();
            //MainPage.waitInSeconds(3);
            driver.SwitchTo().Frame(driver.FindElement(By.CssSelector("#bookForm > div.payment-section > div.payment-instrument-section.bui-spacer--large > div > div > div > div:nth-child(2) > div > div:nth-child(2) > iframe")));
            bookPage.initDriver(driver);
            bookPage.fillPaymentDetails(items[0].Cardnumber, items[0].cardExpiratioDate, items[0].CVCNumber);


          






        }

        [Test]
        private static void tc1()
        {


        }

    }
}
