using System;
using System.Linq;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder();
        }

        static void Guids()
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("f8ca4954-3765-418d-a4eb-799d150ef5b3");
            Console.WriteLine(id.ToString().Substring(0, 8));
        }


        static void Interpolation()
        {
            var price = 10.20;
            // var texto = "O preço do prudot é ";

            // var texto = string.Format("O preço do produto é {0} apenas  na promoção", price);
            var texto = string.Format("O preço do produto é {0} apenas  na promoção {1}", price, true);

            // Console.WriteLine(texto + price);

            Console.WriteLine(texto);
        }

        static void Comparison()
        {
            // var texto = "Testando";
            // Console.WriteLine(texto.CompareTo("Testando"));

            var texto = "este é um teste";

            // Console.WriteLine(texto.Contains("teste"));
            // Console.WriteLine(texto.Contains("Teste"));
            // Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));


            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("Este", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.StartsWith("este"));
        }

        static void Equals()
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.Equals("Este texto é um teste")); //sempre comprar com o mesmo tipo string com string double com double e etc

        }

        static void Indexes()
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.LastIndexOf("s"));
        }

        static void AdditionalMethods()
        {
            var text = "Este é um teste";

            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Insert(5, "Aqui"));
            Console.WriteLine(text.Remove(5, 5));
            Console.WriteLine(text.Length);
            Console.WriteLine();

        }

        static void StringManipulation()
        {
            var text = "Este é um teste";

            Console.WriteLine(text.Replace("Este", "Isto"));

            var divisao = text.Split(" ");
            Console.WriteLine(divisao[0]);


            var resultado = text.Substring(5, 5);
            Console.WriteLine(resultado);
            Console.WriteLine(text.Substring(text.LastIndexOf(" ") + 1, 5));

            Console.WriteLine(text.Trim());
        }

        static void StringBuilder()
        {
            var text = new StringBuilder();

            text.Append("Este é um texto para o teste");
            text.Append("Continuo a escrever para o teste");
            text.Append("Finalizando...");

            Console.WriteLine(text);

        }
    }
}
