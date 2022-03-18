using csharp.Models;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        //IList<Item> Items;
        //public GildedRose(IList<Item> Items)
        //{
        //    this.Items = Items;
        //}

        public void UpdateQuality(List<Item> InventoryItems)
        {
            for (var i = 0; i < InventoryItems.Count; i++)
            {
                if (InventoryItems[i].Name != "Aged Brie" && InventoryItems[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (InventoryItems[i].Quality > 0)
                    {
                        if (InventoryItems[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            InventoryItems[i].Quality = InventoryItems[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (InventoryItems[i].Quality < 50)
                    {
                        InventoryItems[i].Quality = InventoryItems[i].Quality + 1;

                        if (InventoryItems[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (InventoryItems[i].SellIn < 11)
                            {
                                if (InventoryItems[i].Quality < 50)
                                {
                                    InventoryItems[i].Quality = InventoryItems[i].Quality + 1;
                                }
                            }

                            if (InventoryItems[i].SellIn < 6)
                            {
                                if (InventoryItems[i].Quality < 50)
                                {
                                    InventoryItems[i].Quality = InventoryItems[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (InventoryItems[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    InventoryItems[i].SellIn = InventoryItems[i].SellIn - 1;
                }

                if (InventoryItems[i].SellIn < 0)
                {
                    if (InventoryItems[i].Name != "Aged Brie")
                    {
                        if (InventoryItems[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (InventoryItems[i].Quality > 0)
                            {
                                if (InventoryItems[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    InventoryItems[i].Quality = InventoryItems[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            InventoryItems[i].Quality = InventoryItems[i].Quality - InventoryItems[i].Quality;
                        }
                    }
                    else
                    {
                        if (InventoryItems[i].Quality < 50)
                        {
                            InventoryItems[i].Quality = InventoryItems[i].Quality + 1;
                        }
                    }
                }
            }
        }

        //public void UpdateQuality()
        //{
        //    for (var i = 0; i < Items.Count; i++)
        //    {
        //        if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
        //        {
        //            if (Items[i].Quality > 0)
        //            {
        //                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //                {
        //                    Items[i].Quality = Items[i].Quality - 1;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            if (Items[i].Quality < 50)
        //            {
        //                Items[i].Quality = Items[i].Quality + 1;

        //                if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
        //                {
        //                    if (Items[i].SellIn < 11)
        //                    {
        //                        if (Items[i].Quality < 50)
        //                        {
        //                            Items[i].Quality = Items[i].Quality + 1;
        //                        }
        //                    }

        //                    if (Items[i].SellIn < 6)
        //                    {
        //                        if (Items[i].Quality < 50)
        //                        {
        //                            Items[i].Quality = Items[i].Quality + 1;
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //        {
        //            Items[i].SellIn = Items[i].SellIn - 1;
        //        }

        //        if (Items[i].SellIn < 0)
        //        {
        //            if (Items[i].Name != "Aged Brie")
        //            {
        //                if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
        //                {
        //                    if (Items[i].Quality > 0)
        //                    {
        //                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //                        {
        //                            Items[i].Quality = Items[i].Quality - 1;
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    Items[i].Quality = Items[i].Quality - Items[i].Quality;
        //                }
        //            }
        //            else
        //            {
        //                if (Items[i].Quality < 50)
        //                {
        //                    Items[i].Quality = Items[i].Quality + 1;
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
