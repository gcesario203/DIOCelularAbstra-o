namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string model, string imei, int memoria) : base(numero, model, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"{nomeApp} instalado via android");
        }
    }
}