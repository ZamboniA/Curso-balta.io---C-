using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new int[3];
            try
            {
                for (var i = 0; i < 10; i++)
                {
                    Console.WriteLine(arr[i]);
                }

                Casdastrar("");
            }
            //SEMPRE DO MAIS ESPECIFICO PARA O MAIS GENÉRICO.
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Não encontrei o indice na lista.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("Falha ao cadastrar");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine("algo deu errado");
            }
        }

        static void Casdastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new MinhaException(DateTime.Now);
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }

            public DateTime QuandoAconteceu { get; set; }
        }
    }
}
