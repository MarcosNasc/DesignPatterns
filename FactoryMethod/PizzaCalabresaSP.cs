using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    // Concrete Product
    public class PizzaCalabresaSP : Pizza
    {
        public PizzaCalabresaSP()
        {
            Nome = "Pizza de Calabresa Paulista";
            Massa = "Massa fina crocante paulista";
            Molho = "Molho de tomate italiano";
            Ingredientes.Add("Fatias de calabresa defumada especial");
            Ingredientes.Add("Queijo parmesão italiano tradicional");
        }
    }
}
