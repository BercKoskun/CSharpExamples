using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Atama ve İşlemli Operatörler ****");
            // Atama ve İşlemli Atamalar
            int x=3;
            int y=2;
            y= y+2;

            Console.WriteLine(y);
            y +=2;
            Console.WriteLine(y);
            y /=1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("**** Mantıksal Operatörler ****");
            //Mantıksal Operatörler
            // || && ! || -> ifadesi mac de option+ büyük küçük işaretiyle yapılır.

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted) // true ve true ise
            {
                Console.WriteLine("Perfect!");
            }
            if (isSuccess || isCompleted) // true veya true ise
            {
                Console.WriteLine("Great!");
            }
            if(isSuccess && !isCompleted)  // true ve false ise
            {
                Console.WriteLine("Fine!");
            }


            Console.WriteLine("**** İlişkisel Operatörler ****");
            //İlişkisel Operatörler
            // <,>,<=,>=,==,!=

            int a=3;
            int b=4;
            
            bool sonuc= a<b;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            Console.WriteLine("**** İlişkisel Operatörler ****");
            // /,+,-,*,%

            int sayi=100;
            int sayi2= 10;
            int sonuc1= sayi/sayi2;
            Console.WriteLine(sonuc1);
            int sonuc2= sayi+sayi2;
            Console.WriteLine(sonuc2);
            int sonuc3= sayi-sayi2;
            Console.WriteLine(sonuc3);
            int sonuc4= sayi*sayi2;
            Console.WriteLine(sonuc4);
            int sonuc5= sayi%sayi2;
            Console.WriteLine(sonuc5);

            sayi++;
            Console.WriteLine(sayi);





        }
    }
}