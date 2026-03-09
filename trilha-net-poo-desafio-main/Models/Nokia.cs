namespace DesafioPOO.Models
{
    // Herança: Nokia herda da classe abstrata Smartphone
    public class Nokia : Smartphone
    {
        // Construtor: Repassa os parâmetros para a classe base (Smartphone)
        public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // Polimorfismo: Sobrescreve o método abstrato da classe pai
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Nokia via Play Store...");
        }
    }
}