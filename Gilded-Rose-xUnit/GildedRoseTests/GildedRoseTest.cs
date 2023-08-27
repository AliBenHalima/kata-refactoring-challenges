using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using System.Linq;
using FluentAssertions;

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
    }
}
