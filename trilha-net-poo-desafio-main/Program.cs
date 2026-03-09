using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("======= CADASTRO DE SMARTPHONE =======");
            Console.WriteLine("1. Cadastrar e Testar Nokia");
            Console.WriteLine("2. Cadastrar e Testar iPhone");
            Console.WriteLine("0. Sair");
            Console.Write("\nEscolha uma opção: ");

            string opcao = Console.ReadLine();

            if (opcao == "0") break;

            if (opcao != "1" && opcao != "2")
            {
                Console.WriteLine("\nOpção inválida! Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
                continue;
            }

            // Coleta de dados comum a ambos os modelos
            Console.Write("Digite o Número: ");
            string num = Console.ReadLine();

            Console.Write("Digite o Modelo: ");
            string mod = Console.ReadLine();

            Console.Write("Digite o IMEI: ");
            string imei = Console.ReadLine();

            Console.Write("Digite a Memória (em GB): ");
            int mem = int.Parse(Console.ReadLine());

            Smartphone dispositivo = null;

            if (opcao == "1")
            {
                dispositivo = new Nokia(num, mod, imei, mem);
            }
            else
            {
                dispositivo = new Iphone(num, mod, imei, mem);
            }

            // Execução dos testes
            Console.WriteLine("\n--- Realizando Testes no Dispositivo ---");
            dispositivo.Ligar();
            dispositivo.ReceberLigacao();
            
            Console.Write("Qual aplicativo deseja instalar? ");
            string app = Console.ReadLine();
            dispositivo.InstalarAplicativo(app);

            Console.WriteLine("\nTeste concluído! Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        Console.WriteLine("\nSistema encerrado. Até logo!");
    }
}