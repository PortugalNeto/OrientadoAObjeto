using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 10, 50, 32, 87, 98, 64, 1, 4 };
            Console.WriteLine("Digite um inteiro a ser buscado na lista: ");
            string a_str = Console.ReadLine();
            int a = Convert.ToInt32(a_str);
            foreach (var item in numeros)
            {
                if (item == a)
                {
                    Console.WriteLine("Item encontrado!");
                    break;
                }



            }
            Console.ReadKey();

        }
    }
}