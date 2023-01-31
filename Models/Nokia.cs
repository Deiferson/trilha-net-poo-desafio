namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia: Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string emei, int memoria): base(numero, modelo, emei, memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando Aplicativo {nomeApp} ...");
        }
    }
}