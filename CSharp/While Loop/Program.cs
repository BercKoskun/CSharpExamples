// 1'den başlayarak Konsoldan girilen sayıya kadar ortalama hesaplayıp Konsola yazdıran program
Console.Write("Bir Sayı Giriniz: ");
int sayi=int.Parse(Console.ReadLine());
int sayac=1;
int toplam=0;
while (sayac<=sayi)
{
    toplam+= sayac;
    sayac++;
}
Console.WriteLine(toplam/sayi);

// 'a'dan 'z'ye kadar tüm harfleri sırala
char karakter='a';
while (karakter < 'z')
{
        Console.Write(karakter);
        karakter++;
}
Console.WriteLine("***** Foreach*****");

string[] arabalar= {"BMW","Ford","VW"};
foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}

