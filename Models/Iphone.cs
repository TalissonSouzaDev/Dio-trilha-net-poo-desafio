namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        public Iphone(string Numero, string Modelo, string IMEI, int Memoria) : base(Numero,Modelo,IMEI,Memoria)
        {
            
        }


          public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Iphone");
            Console.WriteLine($"Data e hora da instalação: {this.date}");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}