using GildedRose.Interfaces.Factory;
using GildedRoseKata;
using System;

namespace GildedRose.Implementations
{
    public class ConjuredStrategy : IItemStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                {
                    item.Quality = item.Quality - 1;
                }

            }
        }

    }
}
