using System;


namespace OrientadoAObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Olá! Você está na Página de resumo de Entrega **********");

            Cliente novoCliente = new Cliente();

            Console.WriteLine("\nPara que a entrega do seu produto seja realizada com sucesso, confirme alguns dados:");

            Console.Write("\nPor favor, digite seu primeiro nome: ");

            novoCliente.firstName = Console.ReadLine();

            Console.Write("\nPor favor, digite seu último nome: ");

            novoCliente.lastName = Console.ReadLine();

            Console.Write("\nConfirme sua data de Nascimento: ");

            novoCliente.dataDeNascimento = Console.ReadLine();

            Console.Write("\nConfirme seu endereço residencial: ");

            novoCliente.EndereçoResindencial = Console.ReadLine();

            Console.Write("\nQuase lá! Digite seu documento: ");

            novoCliente.documento = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nA entra será feita em sua residência? (Y/N) ");

            string variavel = Console.ReadLine();

            if (variavel == "Y")
            {
                Console.Write("Fechado! Entregaremos em sua residência em até 10 dias!");
                novoCliente.EndereçoResindencial = novoCliente.EndereçoDeEntrega;
            }
            else
            {
                Console.Write("Em qual endereço gostaria que a entrega fosse feita?");
                novoCliente.EndereçoDeEntrega = Console.ReadLine();
            }

            Console.WriteLine("Segue a confirmação de seus dados! =)");
            Console.WriteLine("Nome: " + novoCliente.firstName + " " + novoCliente.lastName);
            Console.WriteLine("Data de Nascimento: " + novoCliente.dataDeNascimento);
            Console.WriteLine("Endereço Residencial: " + novoCliente.EndereçoResindencial);
            Console.WriteLine("Documento: " + novoCliente.documento);
            Console.WriteLine("endereço de entrega: " + novoCliente.EndereçoDeEntrega);
            Console.WriteLine("______________________________________________________");

        }
    }
}
