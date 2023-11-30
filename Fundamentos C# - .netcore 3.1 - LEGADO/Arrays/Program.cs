using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();


            var meuArray = new int[] { 1, 2, 3, 5, 6 };
            // meuArray[0] = 12;
            // int[] testeArray = new int[5];

            // for (var index = 0; index < meuArray.Length; index++)
            // {
            //     Console.WriteLine(meuArray[index]);
            // }

            foreach (var item in meuArray)
            {
                Console.WriteLine(item);
            }

            // Console.WriteLine(meuArray[0]);

            string[] pessoas = { "anderson", "mayara", "lucy", "gilmara", "priscila", "leticia" };


            foreach (var nome in pessoas)
            {
                Console.WriteLine(nome);
            }

            // var funcionarios = new Funcionarios[5];
            // funcionarios[0] = new Funcionarios() { Id = 01, Name = "Anderson" };

            // foreach (var funcionario in funcionarios)
            // {
            //     Console.WriteLine(funcionario.Id);
            //     Console.WriteLine(funcionario.Name);
            // }



            var arr = new int[4];
            var arrb = new int[4];

            arrb[0] = arr[0];
            arr.CopyTo(arrb, 0);
            // arr[0] = 33;
        }

        public struct Funcionarios
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
