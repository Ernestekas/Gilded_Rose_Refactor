using csharp.Models;
using System;

namespace csharp.Services
{
    public class ConsoleService
    {
        public void Run()
        {
            Console.WriteLine("OMGHAI!");

            Inventory inventory = new Inventory();
            inventory.LoadDefaultInventory();

            var app = new GildedRose(inventory.Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < inventory.Items.Count; j++)
                {
                    Console.WriteLine(inventory.Items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }

            Console.ReadKey();
        }
    }
}
