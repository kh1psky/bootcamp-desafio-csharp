using DesafioPOO.Models;
using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            Nokia nokia = new Nokia("12345", "Nokia 9", "123456789", 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");
            //Iphone

            Console.WriteLine("Smartphone Iphone:");
            iPhone iphone = new iPhone("67890", "iPhone 12", "987654321", 128);
            iphone.Ligar();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
