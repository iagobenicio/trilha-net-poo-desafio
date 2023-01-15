namespace DesafioPOO.Models
{
    //implementado
    public class Nokia : Smartphone
    {   

        public Nokia(string numero, string modelo, string imei, int memoria) : base (numero: numero, modelo: modelo, imei: imei, memoria: memoria){}

        //implementado

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia de modelo: {Modelo}");
        }
    }
}