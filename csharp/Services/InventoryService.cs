using csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Services
{
    public class InventoryService
    {
        private readonly GildedRose _gildedRose;

        public InventoryService(GildedRose gildedRose)
        {
            _gildedRose = gildedRose;
        }

        public List<List<string>> GetMonthItemsReport()
        {
            Inventory inventory = new Inventory();
            List<List<string>> monthlyReport = new List<List<string>>();

            for(int day = 0; day < 31; day++)
            {
                List<string> dayItemsReports = new List<string>();
                
                foreach(var item in inventory.Items)
                {
                    string itemReport = item.ToString();
                    dayItemsReports.Add(itemReport);
                }

                monthlyReport.Add(dayItemsReports);
                _gildedRose.UpdateQuality(inventory.Items);
            }

            return monthlyReport;
        }
    }
}
