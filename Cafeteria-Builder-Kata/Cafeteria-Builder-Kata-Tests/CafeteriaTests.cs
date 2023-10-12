using Cafeteria_Builder_Kata;

namespace Cafeteria_Builder_Kata_Tests
{
    public class CafeteriaTests
    {
        [Fact]
        public void Test1()
        {
            var actual = new CoffeeBuilder().SetBlackCoffee().WithSugar("Regular").WithMilk(3.2).Build();
            var expected = new Coffee("Black", new List<Milk> { new Milk(3.2) }, new List<Sugar> { new Sugar("Regular") });
            Assert.Equal(expected.ToString(), actual.ToString());
            Assert.Equal(expected.Sort, actual.Sort);
            Assert.Equal(expected.Milk, actual.Milk);
            Assert.Equal(expected.Sugar, actual.Sugar);
        }   

        [Fact]
        public void Test2()
        {
            var actual = new CoffeeBuilder().SetAntoccinoCoffee().Build();
            var expected = new Coffee("Americano", new List<Milk> { new Milk(0.5) }, new List<Sugar>());
            Assert.Equal(expected.ToString(), actual.ToString());
            Assert.Equal(expected.Sort, actual.Sort);
            Assert.Equal(expected.Milk, actual.Milk);
            Assert.Equal(expected.Sugar, actual.Sugar);
        }

        [Fact]
        public void Test3()
        {
            var actual = new CoffeeBuilder().SetCubanoCoffee().Build();
            var expected = new Coffee("Cubano", new List<Milk>(), new List<Sugar> { new Sugar("Brown") });
            Assert.Equal(expected.ToString(), actual.ToString());
            Assert.Equal(expected.Sort, actual.Sort);
            Assert.Equal(expected.Milk, actual.Milk);
            Assert.Equal(expected.Sugar, actual.Sugar);
        }

    }
}