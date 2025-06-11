namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }=string.Empty;
        private string Modelo { get; set; }=string.Empty;
        private string Imei { get; set; }=string.Empty;
        private int Memoria { get; set; }

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

        public abstract void InstalarAplicativo(string nomeApp);
    }
}