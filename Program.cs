using System;

namespace GFTPresentes
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoEntrada = 0;
            int anoAtual = 2021;

            Console.WriteLine("****************GFT Presentes*****************");
            Console.WriteLine("Informe o ano de entrada");

            anoEntrada = Convert.ToInt32(Console.ReadLine());

            int totalAnos = anoAtual - anoEntrada;

            switch (totalAnos)
            {
                case 1:
                    Console.WriteLine("Vale Presente");
                    break;
                case 2:
                    Console.WriteLine("Smart Watch");
                    break;
                case 5:
                    Console.WriteLine("Fone Bluetooh");
                    break;
                case 10:
                    Console.WriteLine("Vale Jantar");
                    break;
                case 15:
                    Console.WriteLine("Vale Jantar Top");
                    break;
                default:
                    Console.WriteLine("Esse ano não vai ter presente...");
                    break;
            }
        }
    }
}
