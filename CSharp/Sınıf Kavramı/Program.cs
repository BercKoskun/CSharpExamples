// Söz Dizimi //
/*
Sınıflar Nesne Yönelimli Programlamanın en öneeli öğesidir. C# %100 nesne yönelimli bir dil olduğu için tüm metot ve özellikler sınıflar içerisinde yer alır.

Metotlardan bahsederken bütün işlemleri tek bir metot içerisinde yazmak yerine, parçalarına yani alt metotlara ayırmak kod tekrarını azaltırken okunabilirliği arttırır demiştik. Üstelik bu şekilde yazdığınız programların daha kolay genişleyebildiğini görürsünüz.

Aynı şekilde program geliştirirken bütün metotları tek bir sınıf içerisinde yazmak yerine benzer görevleri olan metotları tek bir sınıf içerisinde toplamak en doğru yaklaşımdır.

Bir sınıfın temelde 2 tipte öğesi vardır; field/özellik ve metotlar. Aşağıda örnek bir sınıf tanımının söz dizimini görebilirsiniz.

*/
//class SınıfAdı
//{
//    [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi --> Property (prop tab+tab şeklinde kısa yolla açılabilir.)
//    [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi (Sıra),(Sayi),(Tip)])
//    {
//       Metot Komutları
//    }  
//}

// Erişim Belirleyicileri
// * Public
// * Private (Sadece Tanımlandığı Class içinde erişilebilir )
// * Internal (Sadece Tanımlandığı Proje içinde erişilebilir)
// * Protected (Sadece Tanımlandığı Sınıfta veya O sınıftan kalıtım alan sınıflarda kullanılır.)

Calisan calisan1 = new Calisan();  // --> Instance 
calisan1.Ad = "Mehmet";
calisan1.Soyad = "Pülgir";
calisan1.No = 923;
calisan1.Departman = "Satış";
calisan1.CalisanBilgileri();

Console.WriteLine("*********");

Calisan calisan2 = new Calisan();
calisan2.Ad= "Mehmet";
calisan2.Soyad = "Berber";
calisan2.No = 234;
calisan2.Departman = "İK";
calisan2.CalisanBilgileri();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine($"Çalısanın Adı: {Ad} ");
        Console.WriteLine($"Çalısanın Soyadı: {Soyad} ");
        Console.WriteLine($"Çalısanın No: {No} ");
        Console.WriteLine($"Çalısanın Bölümü: {Departman} ");
    }
}




