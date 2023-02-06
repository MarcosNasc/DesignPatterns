using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    // Concrete Creator
    public class PizzaFactorySP : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            switch (tipo)
            {
                case "M":
                    return new PizzaMussarelaSP();
                    break;
                case "C":
                    return new PizzaCalabresaSP();
                    break;
                default:
                    throw new ApplicationException();
            }
        }
    }
}
