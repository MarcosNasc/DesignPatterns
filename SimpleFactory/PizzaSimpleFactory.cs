using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    // Factory
    public sealed class  PizzaSimpleFactory
    {
        public static Pizza CriarPizza(string tipo)
        {
            Pizza pizza;

            switch(tipo)
            {
                case "C":
                    pizza = new PizzaCalabresa();
                    break;
                case "M":
                    pizza = new PizzaMusarella();
                    break;
                default:
                    throw new ArgumentException($"A pizza de tipo {tipo} não foi encontrada");
                    break;
            }
            return pizza;
        }
    }
}
