using System.Collections;

Console.WriteLine("En büyük ve en küçük 3 sayıyı bulan program.");

int rakam =5;
ArrayList enbuyukuc = new ArrayList();
ArrayList enkucukuc = new ArrayList();
ArrayList dizi = new ArrayList();
for(int i =0; i<rakam; i++)
{
    Console.WriteLine($"Lütfen {i+1}. sayıyı giriniz.");
    int sayi = int.Parse(Console.ReadLine());
    dizi.Add(sayi);
}
dizi.Sort();
foreach(var i in dizi)
    Console.Write(i + " ");
Console.WriteLine();

enkucukuc.Add(dizi[0]);
enkucukuc.Add(dizi[1]);
enkucukuc.Add(dizi[2]);

Console.WriteLine("*** EN KÜÇÜK ÜÇ SAYI ***");
foreach(var i in enkucukuc)
    Console.Write(i + " ");
Console.WriteLine();

int kcktoplam=0;
foreach(int i in enkucukuc)
    kcktoplam = kcktoplam + i;
double kcksonuc = kcktoplam/3;
Console.WriteLine($"En KÜÇÜK 3 sayının ortalaması: {kcksonuc} ");

dizi.Sort();
dizi.Reverse();
enbuyukuc.Add(dizi[0]);
enbuyukuc.Add(dizi[1]);
enbuyukuc.Add(dizi[2]);

Console.WriteLine("*** EN BÜYÜK ÜÇ SAYI ***");
foreach(var i in enbuyukuc)
    Console.Write(i + " ");
Console.WriteLine();

int byktoplam=0;
foreach(int i in enbuyukuc)
    byktoplam = byktoplam + i;
double byksonuc = byktoplam/3;
Console.WriteLine($"En BÜYÜK 3 sayının ortalaması: {byksonuc} ");

double tplmsonuc = byksonuc + kcksonuc;
Console.WriteLine($"Her iki ortalamanın toplamı: {tplmsonuc} ");
