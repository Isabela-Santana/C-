using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidadorCartao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Identificador de Bandeira e Validador de Cartão";
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Analisador de Cartão de Crédito ===");
                Console.Write("\nDigite o número do cartão (ou 'sair'): ");
                string input = Console.ReadLine();

                if (input?.ToLower() == "sair") break;

                // 1. Limpeza e Identificação
                string numeroLimpo = Regex.Replace(input, @"[^\d]", "");
                string bandeira = CartaoService.IdentificarBandeira(numeroLimpo);
                bool ehValido = CartaoService.ValidarLuhn(numeroLimpo);

                // 2. Exibição dos Resultados
                Console.WriteLine("\n------------------------------------");
                Console.WriteLine($"Número Formatado: {FormatarCartao(numeroLimpo)}");
                Console.WriteLine($"Bandeira:         {bandeira}");
                
                Console.ForegroundColor = ehValido ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine($"Status:           {(ehValido ? "VÁLIDO (Passou no Algoritmo de Luhn)" : "INVÁLIDO")}");
                Console.ResetColor();
                Console.WriteLine("------------------------------------");

                Console.WriteLine("\nPressione qualquer tecla para testar outro...");
                Console.ReadKey();
            }
        }

        static string FormatarCartao(string numero) => 
            Regex.Replace(numero, ".{4}", "$0 ").Trim();
    }

    public static class CartaoService
    {
        // Dicionário de Regex para identificação das bandeiras
        private static readonly Dictionary<string, string> RegrasBandeiras = new Dictionary<string, string>
        {
            { "Visa", @"^4[0-9]{12}(?:[0-9]{3})?$" },
            { "MasterCard", @"^(5[1-5][0-9]{14}|2(22[1-9][0-9]{12}|2[3-9][0-9]{13}|[3-6][0-9]{14}|7[0-1][0-9]{13}|720[0-9]{12}))$" },
            { "American Express", @"^3[47][0-9]{13}$" },
            { "Elo", @"^((431274|438935|451416|457393|457631|457632|504175|627780|636297|636368|650031|650033|650035|650051|650405|650485|650486|650487|650488|650507|650508|650509|650511|650541|650542|650544|650545|650546|650547|650548|650742|650743|650744|650745|650746|650747|650748|650901|650902|650903|650904|650905|650906|650907|650908|650909|650910|650911|650912|650913|650914|650915|650916|650917|650918|650919|650920|651652|651653|651654|651655|651656|651657|651658|651659|651660|651661|651662|651663|651664|651665|651666|651667|651668|651669|651670|651671|651672|651673|651674|651675|651676|651677|651678|651679|655000|655001))\d*$" },
            { "Hipercard", @"^(606282\d{10}(\d{3})?)|(3841\d{12})$" },
            { "Diners Club", @"^3(?:0[0-5]|[68][0-9])[0-9]{11}$" },
            { "Discover", @"^6(?:011|5[0-9]{2})[0-9]{12}$" },
            { "JCB", @"^(?:2131|1800|35\d{3})\d{11}$" }
        };

        public static string IdentificarBandeira(string numero)
        {
            foreach (var regra in RegrasBandeiras)
            {
                if (Regex.IsMatch(numero, regra.Value))
                    return regra.Key;
            }
            return "Desconhecida";
        }

        /// <summary>
        /// Implementação do Algoritmo de Luhn (Mod 10)
        /// </summary>
        public static bool ValidarLuhn(string numero)
        {
            if (string.IsNullOrWhiteSpace(numero)) return false;

            int soma = 0;
            bool deveDobrar = false;

            // Percorre o número de trás para frente
            for (int i = numero.Length - 1; i >= 0; i--)
            {
                int digito = int.Parse(numero[i].ToString());

                if (deveDobrar)
                {
                    digito *= 2;
                    if (digito > 9) digito -= 9;
                }

                soma += digito;
                deveDobrar = !deveDobrar;
            }

            return (soma % 10 == 0);
        }
    }
}