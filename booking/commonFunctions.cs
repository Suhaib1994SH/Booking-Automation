using Newtonsoft.Json;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace booking
{
    public class Item
    {
        public string start_date;
        public string end_date;
        public string[] distnations;
        public string firstname;
        public string lastname;
        public string email;
        public string phone;
        public string Cardnumber;
        public string cardExpiratioDate;
        public string CVCNumber;
        
    }
    
    public class commonFunctions
    {

        /// <summary>
        /// chromr driver definition
        /// </summary>
        public static ChromeDriver driver = new ChromeDriver();


        /// <summary>
        /// load json file
        /// </summary>
        /// <returns></returns>

        public static List<Item> LoadJson()
        {
            List<Item> items;
            using (StreamReader r = new StreamReader("../../testingData/data.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Item>>(json);
            }
            return items;
        }
        
        /// <summary>
        /// wait in seconds
        /// </summary>
        /// <param name="waitInSeconds"></param>
        public static void waitInSeconds(double waitInSeconds)
        {
            waitInSeconds = waitInSeconds * 1000;
            Thread.Sleep((int)waitInSeconds);
        }


        }
}
