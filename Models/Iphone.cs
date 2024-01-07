namespace DesafioPOO.Models
{
    // Implementei
    public class Iphone : Smartphone
    {
        //Implementado!!
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        // Implementado!!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");
        }
    }

}