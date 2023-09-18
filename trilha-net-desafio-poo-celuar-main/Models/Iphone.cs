using System;

namespace DesafioPOO.Models
{
    public class iPhone : Smartphone // Herda da classe Smartphone
    {
        public iPhone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iphone");
        }
    }
}
