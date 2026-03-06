using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Instâncias iniciais
List<Pessoa> hospedes = new List<Pessoa>();
Suite suite = null;
Reserva reserva = null;

bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("--- SISTEMA DE HOSPEDAGEM ---");
    Console.WriteLine("1 - Cadastrar Suíte");
    Console.WriteLine("2 - Adicionar Hóspede");
    Console.WriteLine("3 - Finalizar Reserva e Ver Valor");
    Console.WriteLine("4 - Encerrar");
    Console.Write("Opção: ");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Write("Tipo da Suíte (Ex: Premium): ");
            string tipo = Console.ReadLine();
            Console.Write("Capacidade: ");
            int cap = int.Parse(Console.ReadLine());
            Console.Write("Valor da Diária: ");
            decimal valor = decimal.Parse(Console.ReadLine());
            
            suite = new Suite(tipo, cap, valor);
            Console.WriteLine("Suíte cadastrada com sucesso!");
            break;

        case "2":
            Console.Write("Nome do Hóspede: ");
            string nome = Console.ReadLine();
            hospedes.Add(new Pessoa(nome));
            Console.WriteLine("Hóspede adicionado à lista!");
            break;

        case "3":
            if (suite == null || hospedes.Count == 0)
            {
                Console.WriteLine("Erro: Cadastre uma suíte e ao menos um hóspede primeiro.");
            }
            else
            {
                try {
                    Console.Write("Quantidade de dias da reserva: ");
                    int dias = int.Parse(Console.ReadLine());
                    
                    reserva = new Reserva(dias);
                    reserva.CadastrarSuite(suite);
                    reserva.CadastrarHospedes(hospedes);

                    Console.WriteLine("\n--- RESUMO DA RESERVA ---");
                    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
                    Console.WriteLine($"Valor Total: {reserva.CalcularValorDiaria():C}");
                }
                catch (Exception ex) {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    if (exibirMenu)
    {
        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
    }
}

Console.WriteLine("Programa encerrado.");