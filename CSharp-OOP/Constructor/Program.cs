
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


