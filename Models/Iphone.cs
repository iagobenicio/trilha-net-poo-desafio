namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {   

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero: numero, modelo: modelo, imei: imei, memoria: memoria){}

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone de modelo: {Modelo}");
        }
    }
}