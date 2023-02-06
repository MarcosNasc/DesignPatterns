using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaria(string local)
        {
            PizzaFactoryMethod pizzaria;
            switch (local)
            {
                case "S":
                    pizzaria = new PizzaFactorySP();
                    break;
                case "R":
                    pizzaria = new PizzaFactoryRJ();
                    break;
                default:
                    throw new ApplicationException($"A pizzaria {local} não foi encontarada");
            }
            return pizzaria;
        }
    }
}
