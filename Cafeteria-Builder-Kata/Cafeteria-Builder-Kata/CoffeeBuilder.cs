using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria_Builder_Kata
{
    
    public class CoffeeBuilder
    {
        private Coffee _coffee = new Coffee(null, new List<Milk>(), new List<Sugar>());

        public CoffeeBuilder()
        {
        }

        public CoffeeBuilder SetBlackCoffee()
        {
            _coffee.Sort = "Black";
            return this;
        }

        public CoffeeBuilder SetCubanoCoffee()
        {
            _coffee.Sort = "Cubano";
            this.WithSugar("Brown");
            return this;
        }

        public CoffeeBuilder SetAntoccinoCoffee()
        {
            _coffee.Sort = "Americano";
            this.WithMilk(0.5);
            return this;
        }

        public CoffeeBuilder WithMilk(double fat)
        {
            _coffee.Milk.Add(new Milk(fat));
            return this;
        }
        public CoffeeBuilder WithSugar(string sort)
        {
            _coffee.Sugar.Add(new Sugar(sort));
            return this;
        }


        public Coffee Build()
        {
            return _coffee;
        }
    };
}
