

Console.WriteLine($"Çalışan Sayısı: {Calisan.CalisanSayisi} ");

Calisan calisan = new Calisan("Haluk", "Bal","İK");
Console.WriteLine($"Çalışan Sayısı: {Calisan.CalisanSayisi} ");
Calisan calisan2 = new Calisan("Levent", "Aslan","Satış");
Calisan calisan3 = new Calisan("Gamze", "Gezmiş","IT");
Console.WriteLine($"Çalışan Sayısı: {Calisan.CalisanSayisi} ");

Console.WriteLine($"Toplama İşlemi Sonucu: {Islemler.Topla(200,500)}");
Console.WriteLine($"Çıkarma İşlemi Sonucu: {Islemler.Cikar(200,500)}");

class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi;}

    private string Isim;
    private string Soyisim;

    private string Departman;


    static Calisan(){
        calisanSayisi = 0;
    }
    public Calisan(string isim, string soyisim, string departman)
    {
        this.Isim = isim;
        this.Soyisim= soyisim;
        this.Departman = departman;
        calisanSayisi++;
    }
}


static class Islemler
{
    public static long Topla(int sayi1,int sayi2)
    {
        return sayi1+sayi2;
    }
    public static long Cikar(int sayi1, int sayi2)
    {
        return sayi1-sayi2;
    }
}



