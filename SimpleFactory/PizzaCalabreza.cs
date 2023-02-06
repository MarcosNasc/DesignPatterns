using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class PizzaCalabreza : Pizza
    {
        public PizzaCalabreza()
        {
            Nome = "Pizza de calabresa";
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
