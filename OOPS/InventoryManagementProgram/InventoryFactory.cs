using Newtonsoft.Json;
using OOPS.InventoryDataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.InventoryManagementProgram
{
    public class InventoryFactory
    {
        public InventoryDetails ReadJson(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<InventoryDetails>(json);
                return inventory;
            }
        }
        public void WriteToJson(string filePath, InventoryDetails details)
        {
            var json = JsonConvert.SerializeObject(details);
            File.WriteAllText(filePath, json);
        }
    }
}
