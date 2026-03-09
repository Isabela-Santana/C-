namespace DesafioPOO.Models
{
    // Herança: Iphone "é um" Smartphone
    public class Iphone : Smartphone
    {
        // Construtor: Passa os parâmetros para a classe base (Smartphone) usando "base"
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // Polimorfismo: Sobrescreve o método abstrato da classe pai
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone via App Store...");
        }
    }
}