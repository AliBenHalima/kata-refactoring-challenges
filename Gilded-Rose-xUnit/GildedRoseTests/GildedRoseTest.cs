using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using System.Linq;
using FluentAssertions;
using GildedRose.Interfaces.Factory;
using GildedRose.Implementations.Factory;
using GildedRose.Helpers;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        //[Fact]
        public void Item_Name_Should_Not_Change()
        {
            // Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 } };
            RefactoredGildedRose app = new RefactoredGildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Assert.Equal("Aged Brie", Items[0].Name);
        }

        [Fact]
        public void AgedBrie_Should_Return_1_As_Quality()
        {
            // Arrange
            List<Item> data = new List<Item> { new Item {
                Name = "Aged Brie", Quality = 0, SellIn = 100,
            } };
            // Act
               var sut = new RefactoredGildedRose(data);
            sut.UpdateQuality();
            // Assert
            data.First().Quality.Should().Be(1);
        }

        [Fact]
        public void Conjured_Item_Quantity_And_Sellin_Should_Be_Updated()
        {
            // Arrange
            IGildedRoseFactory factory = new GildedRoseFactory();
            var item = new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 };

            // Act
            var strategy = factory.CreateItemStartegy(item.Name);
            strategy.UpdateQuality(item);
            // Assert
            item.Quality.Should().Be(4);
            item.SellIn.Should().Be(2);
        }

        [Fact]
        public void GildedRoseFactory_Should_Return_A_Strategy()
        {
            // Arrange
            IGildedRoseFactory factory = new GildedRoseFactory();
            string name = "Conjured Mana Cake";

            // Act
            var strategy = factory.CreateItemStartegy(name);
            // Assert
            
        }

    }
}
