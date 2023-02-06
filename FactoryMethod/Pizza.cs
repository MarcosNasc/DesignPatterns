using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    // Abstract Product
    public abstract class Pizza
    {
        public string Nome { get; set; }
        protected string Massa { get; set; }
        protected string Molho { get; set; }
        protected List<string> Ingredientes { get; set; } = new List<string>();

        public string Preparar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Preparando {Nome} \n");
            sb.Append($"{Massa} \n");
            sb.Append($"{Molho} \n");
            sb.Append($"Ingredientes: \n");
            foreach (string ingrediente in Ingredientes)
            {
                sb.Append($"\t {ingrediente} \n");
            }
            sb.Append(Cozinhar());
            sb.Append(Fatiar());
            sb.Append(Embalar());

            return sb.ToString();
        }

        public virtual string Cozinhar()
        {
            return "Cozinhar por 25 minutos a 350 graus \n";
        }

        public virtual string Fatiar()
        {
            return "Fatiar a pizza em 8 pedaços \n";
        }

        public virtual string Embalar()
        {
            return "Embalar a pizza com embalagem oficial \n";
        }
    }
}
