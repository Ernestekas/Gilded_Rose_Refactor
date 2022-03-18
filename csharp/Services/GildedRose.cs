using csharp.Models;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    public class GildedRose
    {
        public void UpdateQuality(Inventory inventory)
        {
            List<Item> agedBries = inventory.Items.Where(i => i.Name.Contains("Aged Brie")).ToList();
            List<Item> legendaryItems = inventory.Items.Where(i => i.Name.Contains("Sulfuras")).ToList();
            List<Item> backstagePasses = inventory.Items.Where(i => i.Name.Contains("Backstage passes")).ToList();
            List<Item> conjuredItems = inventory.Items.Where(i => i.Name.Contains("Conjured")).ToList();

            List<Item> commonItems = 
                inventory.Items
                .Where(i => !i.Name.Contains("Backstage passes") 
                            && !i.Name.Contains("Sulfuras") 
                            && !i.Name.Contains("Aged Brie") 
                            && !i.Name.Contains("Conjured"))
                .ToList();

            UpdateAgedBries(agedBries);
            UpdateLegendaries(legendaryItems);
            UpdateBackstagePasses(backstagePasses);
            UpdateConjuredItems(conjuredItems);
            UpdateCommonItems(commonItems);
        }

        private void UpdateConjuredItems(List<Item> conjured)
        {
            foreach(var item in conjured)
            {
                item.SellIn--;
                DecreaseQuality(item, 2);
            }
        }

        private void UpdateCommonItems(List<Item> items)
        {
            foreach(var item in items)
            {
                item.SellIn--;
                DecreaseQuality(item);
            }
        }

        private void UpdateBackstagePasses(List<Item> passes)
        {
            foreach (var pass in passes)
            {
                pass.SellIn--;

                if(pass.SellIn < 0)
                {
                    continue;
                }
                if(pass.SellIn == 0)
                {
                    pass.Quality = 0;
                    continue;
                }
                if(pass.SellIn <= 5)
                {
                    IncreaseQuality(pass, 3);
                    continue;
                }
                if(pass.SellIn <= 10)
                {
                    IncreaseQuality(pass, 2);
                    continue;
                }
                if(pass.SellIn > 10)
                {
                    IncreaseQuality(pass);
                }
            }
        }

        private void UpdateAgedBries(List<Item> cheese)
        {
            foreach(var c in cheese)
            {
                c.SellIn--;
                IncreaseQuality(c);
            }
        }

        private void UpdateLegendaries(List<Item> legendaryItems)
        {
            foreach(var item in legendaryItems)
            {
                item.SellIn--;
            }
        }

        private void IncreaseQuality(Item item, int increaseBy = 1)
        {
            item.Quality = item.Quality < 50 ? item.Quality + increaseBy : item.Quality;
            item.Quality = item.Quality > 50 ? 50 : item.Quality;
        }

        private void DecreaseQuality(Item item, int decreaseBy = 1)
        {
            if(item.Quality == 0)
            {
                return;
            }

            if(item.SellIn >= 0)
            {
                item.Quality -= decreaseBy;
            }
            else
            {
                item.Quality -= 2;
            }

            if(item.Quality < 0)
            {
                item.Quality = 0;
            }
        }
    }
}
