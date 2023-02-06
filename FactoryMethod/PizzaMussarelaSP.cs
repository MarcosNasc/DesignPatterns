using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    // Concrete Product
    public class PizzaMussarelaSP : Pizza
    {
        public PizzaMussarelaSP()
        {
            Nome = "Pizza Mussarela Paulista";
            Massa = "Massa fina crocante paulista";
            Molho = "Molho de tomate italiano paulista";
            Ingredientes.Add("Queijo parmessão");
            Ingredientes.Add("Azeitonas verdes");
        }
    }
}
