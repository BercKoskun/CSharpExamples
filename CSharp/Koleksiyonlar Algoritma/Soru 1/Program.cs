using System.Collections;
Console.WriteLine("Programımız 20 rakamı Asal olup olmama durumuna göre ayırır. Ardından bize bu diziler hakkında bilgileri verir.");
ArrayList asal= new ArrayList();
ArrayList asalolmayan = new ArrayList();
int rakam =20;
for (int i = 0; i < rakam; i++)
{
    try
    {
    Console.WriteLine($"Lütfen {i+1}. sayıyı giriniz. ");
    int sayi = int.Parse(Console.ReadLine());
    
    if(sayi>0)
    {
        int sayac = 0;
        for(int j = 2 ; j< sayi;j++)
        {
            if(sayi % j == 0)
                sayac ++;
        }
        if(sayac > 0)
            asalolmayan.Add(sayi);
        else if (sayac == 0)
            asal.Add(sayi);
    }
    else if (sayi == 0)
    {
        asal.Add(sayi);
    }
    else
    {
        throw new Exception("Negatif Sayı Giremezsiniz. ");
        
    }
    }
    catch(FormatException fex)
    {
        Console.WriteLine("Metinsel ifade girmeyiniz.");
        Console.WriteLine(fex);
    }

}
int asaltoplam = 0;
foreach (int k in asal)
{
    asaltoplam = asaltoplam + k;
}
double asalavg = asaltoplam/asal.Count;

int asalolmayantoplam = 0;
foreach (int k in asalolmayan)
{
    asalolmayantoplam = asalolmayantoplam + k;
}    
int asalolmayanavg = asalolmayantoplam/asalolmayan.Count;



asal.Sort();
asal.Reverse();
Console.WriteLine("Asal Sayı Listesi: ");
foreach (var k in asal)
    Console.Write(k + " ");

Console.WriteLine();
Console.WriteLine($"Eleman sayısı: {asal.Count} ");
Console.WriteLine($"Sayı dizisinin ortalaması: {asalavg} ");
//
Console.WriteLine();
//
asalolmayan.Sort();
asalolmayan.Reverse();
Console.WriteLine("Asal Olmayan Sayı Listesi: ");
foreach(var k in asalolmayan)
    Console.Write(k + " ");
Console.WriteLine();
Console.WriteLine($"Eleman sayısı: {asalolmayan.Count} ");
Console.WriteLine($"Sayı dizisinin ortalaması: {asalolmayanavg} ");



















