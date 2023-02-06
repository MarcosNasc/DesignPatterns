using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Pizzaria
    {
        public static void SolicitarPizza()
        {
            Console.WriteLine("======Pizzaria======");
            Console.WriteLine("Informe a pizza (C)alabresa | (M)ussarela \n");
            var tipo = Console.ReadLine().ToUpper();
            try
            {
                Pizza pizza = PizzaSimpleFactory.CriarPizza(tipo);
                pizza.Preparar();
                pizza.Assar(10);
                pizza.Embalar();

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
