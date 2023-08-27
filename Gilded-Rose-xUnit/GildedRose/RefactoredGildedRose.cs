using GildedRose.Implementations;
using GildedRose.Implementations.Factory;
using GildedRose.Interfaces;
using GildedRose.Interfaces.Factory;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class RefactoredGildedRose : IGildedRose
    {
       private readonly IList<Item> Items;
        public RefactoredGildedRose(IList<Item> items)
        {
            Items = items;
        }

        public void UpdateQuality()
        {
            IGildedRoseFactory factory = new GildedRoseFactory();
            foreach (Item item in Items)
            {
                IItemStrategy startegy = factory.CreateItemStartegy(item.Name);
                startegy.UpdateQuality(item);
            }
            
        }

    }

}
