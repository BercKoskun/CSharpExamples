using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger;
            deger=2;
            Console.WriteLine(deger);
            //
            string degisken=null;
            //
            
            byte b=5;       //1byte
            sbyte c=5;      //1byte

            short s=5;      //2byte
            ushort us=5;    //2byte (0'dan küçük değer alamaz.)

            Int16 i16=2;    //2byte
            int i =2;       //4byte
            Int32 i32=2;    //4byte
            Int64 i64=2;    //8byte
            uint ui=2;      //4byte
            long l=4;       //8byte
            ulong ul=4;     //8byte

            //(Reel Sayılar)
            float f=5;      //4byte 
            double d=5;     //8byte
            decimal de=5;   //16byte

            char ch='2';    //2byte     (tek karakterse char kullan!)
            string str="Berk";  // Sınırsız 

            bool b1=true;
            bool b2=false;

            DateTime dt= DateTime.Now;
            Console.WriteLine(dt);

            //Her nesne ve değişken "object"ten türer.
            object a1="x";
            object a2= "y";
            object a3=4;
            object a4=3.2;

            string str1=string.Empty;
            str1="Mahmut Ekrem";
            string ad="Berk";
            string soyad="Coskun";
            string tamisim = ad + ""+ soyad;

            int integer1=5;
            int integer2=3;
            int integer3= integer1 *integer2;

            //boolean
            bool bool1 = 10>2;

            //Değişkenler Dönüşümler
            string str20="20";
            int int20 =20;
            string yeniDeger =str20 + int20.ToString();
            Console.WriteLine(yeniDeger); //Cıktısı: 2020

            int int21= int20+Convert.ToInt32(str20);
            Console.WriteLine(int21); //Cıktısı: 40

            int int22= int20+ int.Parse(str20); //Cıktısı: 40

            //Datetime

            string datetime =DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 =DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);


            string hour = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(hour);

        }
    }
}