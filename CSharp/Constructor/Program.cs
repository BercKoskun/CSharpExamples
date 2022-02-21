/*
Bir sınıftan bir nesne oluşturulduğunda biz tanımlamasak bile arka planda çalışan varsayılan yapıcı metotlara kurucu yada constructor denir. Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu metotlar içerisinde yaparız.

Kurucu metot tanımlarken dikkat edilmesi gereken noktalar ise şu şekildedir:
*Yapıcı metotların isimleri sınıf isimleri ile aynı olmak zorundadır.
*Public olarak bildirilmeleri gerekir.
*Geri dönüş değerleri yoktur.

Kurucu metotların imzasını değiştirerek overload edebiliriz yani aşırı yükleyebiliriz. Metotları anlatırken aşırı yüklemeden bahsetmiştik. (Bkz: Metotların Aşırı Yüklenmesi)

*Varsayılan Kurucu Metot
Her sınıfın biz tanımlamasakta bir tane kurucu metotu vardır. Buna varsayılan kurucu metot (default constructor) denir.
Default constructor'ın görevi sınıfın içerindeki özelliklere ilk değer ataması yapılmadığında onların default değerlerini set etmektir. Şöyle düşünebilirsiniz; sınıf içerisinde string veri tipinde bir özellik varsa ve siz ilk değer atamasını yapmazsanız varsayılan kurucu onun atamasını arka planda null olarak yapar. Aynı integer tipinde bir özelliğin ilk değer atamasını 0 olarak yapar.

*/
Console.WriteLine("*** Çalışan Bir ***");

Calisan calisan1 = new Calisan("Mahmut", "Kuzu", 1231, "IT");
calisan1.CalisanBilgileri();

Console.WriteLine("*** Çalışan İki ***");

Calisan calisan2 = new Calisan ("Deniz", "Yıldızı", 435,"Satış");
calisan2.CalisanBilgileri();

Console.WriteLine("*** Çalışan Üç ***");
Calisan calisan3 = new Calisan("Ahmet", "Aslan");
calisan3.CalisanBilgileri();


class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string soyad,int no,string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }

    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }


    public Calisan(){}

    public void CalisanBilgileri()
    {
        Console.WriteLine($"Çalışanın Adı: {Ad} ");
        Console.WriteLine($"Çalışanın Soyadı: {Soyad} ");
        Console.WriteLine($"Çalışanın Numarası: {No} ");
        Console.WriteLine($"Çalışanın Departman: {Departman} ");
    }
}


