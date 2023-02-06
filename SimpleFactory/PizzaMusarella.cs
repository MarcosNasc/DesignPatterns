using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class PizzaMusarella : Pizza
    {
        public PizzaMusarella()
        {
            Nome = "Pizza de Musarella";
        }

        public override void Preparar()
        {
            Console.WriteLine($"Preparando {Nome}");
        }

        public override void Assar(int tempo)
        {
            Console.WriteLine($"{Nome} assando por {tempo} min.");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando pizza de {Nome}");
        }
    }


}
