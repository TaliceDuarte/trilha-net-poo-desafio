namespace DesafioPOO.Models
{
    // *IMLEMENTADO *TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero)
        {

        }

        // **IMPLEMENTADO** TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Aplicativo Instalado no smartphone Nokia\n"
            +$"Numero: {Numero}\n");
        }
    }
}