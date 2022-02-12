// void metotlar hariç diğer metotlarda "return" ifadesi kullanılmalı. Bunun sebebi void metotlar geriye dönmezken diğer tip türlerindeki metotlar geriye dönen ifadeleri içerir. 
// out parametreler
string sayi ="999";
bool sonuc =int.TryParse(sayi, out int outSayi);
if(sonuc)
{
    Console.WriteLine("Başarılı");
    Console.WriteLine(outSayi);
}
else
{
    Console.WriteLine("Başarısız.");
}

//instance oluşturma

Metotlar instance = new Metotlar();
instance.Topla(4,5,out int toplamSonucu);
Console.WriteLine(toplamSonucu);


// Metot Aşırı Yükleme -> Overloading
int ifade=999;
instance.EkranaYazdır(ifade);
instance.EkranaYazdır("C# ","Programlama");

class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam=a+b;
    }

    // Metot Aşırı Yükleme -> Overloading
    // Metot Imzası -> metotAdı + parametre sayisi + parametre tipi ( Metot'un içindeki imzaların farklı olması gerekir.)
    public void EkranaYazdır(string veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdır(int veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdır(string veri1,string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    }


}