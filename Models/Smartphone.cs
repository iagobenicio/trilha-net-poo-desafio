namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        //implementado

        protected string Modelo => _modelo;
        private string _modelo;
        private string _imei;
        private int _memoria;
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            //implementado
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}