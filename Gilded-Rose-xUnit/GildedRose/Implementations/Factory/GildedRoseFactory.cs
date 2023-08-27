using GildedRose.Interfaces.Factory;
using System;

namespace GildedRose.Implementations.Factory
{
    public class GildedRoseFactory : IGildedRoseFactory
    {
        public IItemStrategy CreateItemStartegy(string Name)
        {
            switch (Name)
            {
                case "Aged Brie":
                    return new AgedBrieStrategy();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstageStrategy();
                case "Sulfuras, Hand of Ragnaros":
                    return new SulfurasStrategy();
                default:
                    return new InvalidStrategy();

            }
        }
    }
}
