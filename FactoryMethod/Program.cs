namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======Pizzaria======");
            Console.WriteLine("Informe o local (S)ão Paulo | (R)io de janeiro \n");
            var localEscolhido = Console.ReadLine().ToUpper();

            Console.WriteLine("Informe a pizza (C)alabresa | (M)ussarela \n");
            var pizzaEscolhida = Console.ReadLine().ToUpper();


            try
            {
                PizzaFactoryMethod pizzaria = PizzaSimpleFactory.CriarPizzaria(localEscolhido);
                Pizza pizza = pizzaria.MontaPizza(pizzaEscolhida);

                Console.WriteLine(pizza.Preparar());
                Console.WriteLine($"\n {pizza.Nome} concluida com sucesso");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}