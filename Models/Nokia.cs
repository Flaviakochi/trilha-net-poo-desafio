namespace DesafioPOO.Models
{
    // implementei
    public class Nokia : Smartphone
    {
        // Implementado!!
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        // Implementado!!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia.");
        }
    }
}