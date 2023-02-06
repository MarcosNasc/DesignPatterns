using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    // Concrete Product
    public class PizzaCalabresaRJ : Pizza
    {
        public PizzaCalabresaRJ()
        {
            Nome = "Pizza de calabresa Carioca com cebola";
            Massa = "Massa tradicional carioca";
            Molho = "Molho de tomate italiano carioca";
            Ingredientes.Add("Fatias de calabresa especial");
            Ingredientes.Add("Queijo parmessão italizano tradicional");
        }
    }
}
