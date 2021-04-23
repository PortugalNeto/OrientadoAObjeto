using System;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao sistema de cadastro de Clientes!");
            Console.WriteLine("Digite o seu nome: ");
            string nome;
            nome = Console.ReadLine();
            string cpf_str;
            Console.WriteLine("Digite o seu CPF: ");
            cpf_str = Console.ReadLine();
            int cpf = Int32.Parse(cpf_str);
            Console.WriteLine("Seu nome é " + nome + "e seu CPF é " + cpf + "Confirma? S/N");
            Console.ReadLine();
        }
    }
}
