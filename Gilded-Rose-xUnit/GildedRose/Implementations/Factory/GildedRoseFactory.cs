using GildedRose.Helpers;
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
                case Constants.AgedBrie:
                    return new AgedBrieStrategy();
                case Constants.Backstage:
                    return new BackstageStrategy();
                case Constants.Sulfuras:
                    return new SulfurasStrategy();
                case Constants.Conjured:
                    return new ConjuredStrategy();
                default:
                    return new RandomStrategy();

            }
        }
    }
}
