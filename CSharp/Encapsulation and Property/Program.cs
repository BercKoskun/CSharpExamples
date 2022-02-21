/*
Siz bir propery yani özellik tanımı yaptınız ve diğer sınıflar içerisinden erişilsin ama sadece okumak için erişilsin değeri dışarıdan değiştirilemesin istiyorsunuz bunu kapsülleme yaparak sağlayabilirsiniz. Kapsülleme işlemini ise property leri kullanarak yapabilirsiniz.

Kapsülleme sayesinden nesneler bilinçsiz olarak kullanımdan korunmuş olur. Fakat bazı durumlarda private field'lara erişmemiz ve özelliklerini değiştirmemiz gerekebilir. Bu durumda Property Kavramı devreye girer. Property bir field'ın değerini geri döndürmeye(Get) ve yeni bir değer(Set) atamaya olanak sağlar.
*/

Ogrenci ogrenci1 = new Ogrenci();
ogrenci1.Isim = "Bülent";
ogrenci1.Soyisim = "Kuzu";
ogrenci1.OgrenciNo = 4213;
ogrenci1.Sinif = 3;
ogrenci1.OgrenciBilgilerinigetir();

Ogrenci ogrenci2 = new Ogrenci("Vahap", "Altan", 24,1);
ogrenci2.SinifDusur();
ogrenci2.SinifDusur();
ogrenci2.OgrenciBilgilerinigetir();




class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim 
    {
        get {return isim;}
        set {isim = value;}
    }

    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif 
    { 
        get => sinif; 
        set 
        { 
            if(value <1)
            {
                Console.WriteLine("Sınıf en az 1 olabilir.");
                sinif =1 ;
            }
            else
                sinif = value;
        } 
    }

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = isim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }

    public Ogrenci(){}

    public void OgrenciBilgilerinigetir()
    {
        Console.WriteLine("**** Öğrenci Bilgileri ****");
        Console.WriteLine($"Öğrenci Adı: {this.Isim}");
        Console.WriteLine($"Öğrenci Soyisim: {this.Soyisim}");
        Console.WriteLine($"Öğrenci Adı: {this.OgrenciNo}");
        Console.WriteLine($"Öğrenci Adı: {this.Sinif}");
    }

    public void SinifAtlat()
    {
        this.Sinif= this.Sinif + 1;
    }
    public void SinifDusur()
    {
        this.Sinif = this.Sinif -1;
        
    }
}



