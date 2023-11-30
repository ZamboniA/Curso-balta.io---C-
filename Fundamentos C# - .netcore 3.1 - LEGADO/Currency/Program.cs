using System;
using System.Globalization;

namespace Currency
{
    class Program
    {
        static void Main(string[] args)
        {

            // var valor = 10.25;
            decimal valor = 10.21524545m;

            var culture = CultureInfo.CreateSpecificCulture("pt-BR");
            // var culture = CultureInfo.CreateSpecificCulture("en_US");


            // Console.WriteLine(valor.ToString("C", culture));

            //arredondar moedas

            Console.WriteLine(
                Math.Round(valor)
            );

            Console.WriteLine(
                Math.Ceiling(valor)
            );

            Console.WriteLine(
                Math.Floor(valor)
            );
        }
    }
}
