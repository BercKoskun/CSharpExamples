using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm) -> Makine sizin yerinize yapar.
            Console.WriteLine("***** Implicit Conversion");
            byte a=5;
            sbyte b =30;
            short c=12;

            int d = a+b+c;
            Console.WriteLine($"{d}");

            long h = d;
            Console.WriteLine($"{h}");

            float i = h;
            Console.WriteLine($"{i}");

            string n="Berk";
            char f='C';
            object g = n+f;
            Console.WriteLine($"{g}");

            //Explicit Conversion (Bilinçli Dönüşüm) -> Manuel yapılan dönüşüm
            Console.WriteLine("***** Explicit Conversion");
            int x =4;
            byte y=(byte)x;
            Console.WriteLine($"{y}");

            int z=100;
            byte t =(byte)z;
            Console.WriteLine($"{t}");

            float w=10.56f;
            byte v=(byte)w;
            Console.WriteLine($"{v}");

            //ToString Metodu
            Console.WriteLine("***** ToString Metodu");
            int xx=6;
            string yy=xx.ToString();
            Console.WriteLine($"{yy}");

            string zz= 12.5f.ToString();
            Console.WriteLine($"{zz}");

            // System.Convert
            Console.WriteLine("***** Convert Metodu");
            string s1 = "10", s2="29";
            int sayi1,sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam =sayi1+sayi2;
            Console.WriteLine($"{toplam}");

            // Parse 
            Console.WriteLine("***** Parse Metodu");
            ParseMethod();

        }
        static void ParseMethod()
        {
            string metin1="10";
            string metin2="10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1=Double.Parse(metin2);

            Console.WriteLine($"{rakam1}");
            Console.WriteLine($"{double1}");

        }   
    }
}
