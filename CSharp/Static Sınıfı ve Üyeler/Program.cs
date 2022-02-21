/*
*Static Üyeler

Bir sınıfın static olamayan üyelerine nesneler aracılığıyla erişirken static olan metotlara ve özelliklere ise nesne oluşturmadan o sınıfın ismi aracılığıyla erişiriz.

Aşağıda hem static hemde static olmayan sınıf üyesine sahip bir sınıf tanımı ve program içerisinden kullanımı görüyorsunuz. Static olmayan üyeler nesne bazında yaratılırken static sınıf üyeleri uygulama çalıştığı sürece kendilerine atanan veriyi tutarlar. Yani yukarıdaki örnek için konuşursak, "Isim" ve "Soyisim" her nesne yaratıldığında başlangıç değeri olarak null alır, ataması yapıldığındaysa nesne bazında değerini tutar. Ama "Ogrenci Sayısı" field'ı program boyunca nesne yaratıldıkça öğrenci sayısının değerini 1 arttırarak bu veriyi korur.

Yukarıdaki örnekte de görebileceğiniz gibi bir özelliği static yapmak için geri dönüş tipi yada veri tipinden önce erişim belirleyiciden sonra "static" anahtar kelimesini koymanız yeterlidir.

Normal metotlar gibi kurucu metotları da static olarak tanımlayabiliriz. Sınıfın static üyelerinin başlangıç değerlerini static kurucular aracılığıyla yapabiliriz. Parametre almazlar ve erişim belirleyicileri yoktur.

*Static Sınıflar

Metotlar ve özellikler gibi sınıflar da static anahtar kelimesi ile oluşturulabilirler. Yukarıdaki örnekte de görebileceğiniz üzere normal sınıflar içerisinde static metotlar ve üyeler kullanabiliriz. Peki o halde neden sınıfları static yapma ihtiyacımız olsun? Buna okunabilirliği arttırmak için diyebiliriz.
Bir sınıfın tüm üyeleri static ise sınıfı da static yapmak kullanımı kolaylaştıran bir yaklaşım olur.

*/

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



