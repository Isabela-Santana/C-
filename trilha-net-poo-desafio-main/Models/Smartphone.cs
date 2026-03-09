using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedade pública
        public string Numero { get; set; }

        // Propriedades faltantes (Encapsuladas para serem alteradas apenas dentro das classes)
        protected string Modelo { get; set; }
        protected string Imei { get; set; }
        protected int Memoria { get; set; }

        // Construtor completo para inicializar todas as propriedades
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato: as classes filhas (Nokia e Iphone) SÃO OBRIGADAS a implementar
        public abstract void InstalarAplicativo(string nomeApp);
    }
}