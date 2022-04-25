using OOPS.InventoryDataManagement;
using System;
namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory Management ");
            const string INVENTORY_DATA_PATH = @"D:\RFP BATCH 135\ObjectOrientedPrograms\OOPS\OOPS\InventoryDataManagement\Inventory.json";
            InventoryManagement inventoryData = new InventoryManagement();
            Console.WriteLine("Display 1\n");
            bool check = true;
            while (check)
            {
                Console.WriteLine("Choose your option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        inventoryData.DisplayInventory(INVENTORY_DATA_PATH);
                        break;
                    default:
                        break;

                }
            }
        }
    }
}