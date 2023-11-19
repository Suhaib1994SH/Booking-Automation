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
using System.Runtime.CompilerServices;

namespace booking
{


    [TestFixture]
    public class TestCases : commonFunctions
    {

        /// <summary>
        /// Run Method Only Once before tests
        /// </summary>
        /// 
        [OneTimeSetUp]
        public static void Start()
        {

        }

        [Test,Retry(2)]
        public static void TC_7_verify_that_user_can_confirm_the_payment_for_booking_an_Apartment()
        {

            MainPage.navigateToMainPage();
            List<Item> items = commonFunctions.LoadJson();
            MainPage.fillDestName(items[0].distnations[0]);
            MainPage.fillFrstEndDates(items[0].start_date, items[0].end_date);
            MainPage.clickSearch();
            SearchResultsPage.clickOnSeeAvalibblty();
            hotelPage.clickOnReserve();
            hotelPage.clickOnConfirmReserve();
            bookPage.fillBookingDetails(items[0].firstname, items[0].lastname, items[0].email, items[0].phone);
            bookPage.fillPaymentDetails(items[0].Cardnumber, items[0].cardExpiratioDate, items[0].CVCNumber);

        }

        /// <summary>
        /// Run Method Only Once After tests
        /// </summary>

        [OneTimeTearDown]
        public static void End()
        {

            driver.Close();
            driver.Quit();

        }



    }
}
