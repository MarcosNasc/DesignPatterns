using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PizzaFactoryRJ : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            switch (tipo)
            {
                case "M":
                    return new PizzaMussarelaRJ();
                    break;
                case "C":
                    return new PizzaCalabresaRJ();
                    break;
                default:
                    throw new ApplicationException();
            }
        }
    }
}
