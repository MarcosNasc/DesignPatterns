using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    // Concrete Product
    public class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ()
        {
            Nome = "Pizza de Musarrela Carioca";
            Massa = "Massa tradicional carioca";
            Molho = "Molho de tomate italiano carioca";
            Ingredientes.Add("Queijo parmessão ralado");
            Ingredientes.Add("Azeitonas pretas");
        }
    }
}
