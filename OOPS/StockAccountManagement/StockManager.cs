using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.StockAccountManagement
{
    public class StockManager
    {
        StockData data = new StockData();
        public void DisplayStock(string filePath)
        {
            using(StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject < List < StockData >> (json);
                Console.WriteLine("Name" + "\t" + "Number" + "\t" + "Price" + "\t" + "TotalPrice");
                foreach (var data in inventory)
                {
                    Console.WriteLine(data.NameOfStock + "\t" + data.NumberOfStock + "\t" + data.PriceOfStock + "\t\t" + (data.NumberOfStock * data.PriceOfStock));
                }
            }
        }
    }
}
