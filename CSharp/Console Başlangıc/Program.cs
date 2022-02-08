using System;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Adınız: ");
            string name=Console.ReadLine();
            Console.WriteLine("Soyadınız: ");
            string surname=Console.ReadLine();

            Console.WriteLine($"Hoşgeldiniz {name} {surname}");
        }
    }
}
