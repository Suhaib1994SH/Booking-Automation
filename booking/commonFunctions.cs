using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    internal static class commonFunctions
    {
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


    }
}
