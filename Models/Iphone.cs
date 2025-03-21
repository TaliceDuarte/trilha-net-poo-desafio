namespace DesafioPOO.Models
{
    //** IMPLEMENTADO **TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(String nomeApp)
        {
            Console.WriteLine("Aplicativo Instalado no smartphone Iphone\n"
            +$"Numero: {Numero}\n");
        }
    }
}