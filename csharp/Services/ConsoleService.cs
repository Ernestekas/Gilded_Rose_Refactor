using System;

namespace csharp.Services
{
    public class ConsoleService
    {
        private readonly InventoryService _inventoryService;

        public ConsoleService(InventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        public void Run()
        {
            var monthlyInventoryReport = _inventoryService.GetMonthItemsReport();
            Console.WriteLine("OMGHAI!");

            for (var day = 0; day < monthlyInventoryReport.Count; day++)
            {
                Console.WriteLine("-------- day " + (day + 1) + " --------");
                Console.WriteLine("name, sellIn, quality");

                foreach(var itemReport in monthlyInventoryReport[day])
                {
                    Console.WriteLine(itemReport);
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
