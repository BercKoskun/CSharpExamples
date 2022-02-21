

Console.WriteLine(Gunler.Pazar);
Console.WriteLine((int)Gunler.Cumartesi);


int sıcaklık=32;
if(sıcaklık <= (int)HavaDurumu.Normal)
    Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekleyelim");
else if(sıcaklık >=(int)HavaDurumu.Sıcak)
    Console.WriteLine("Dışarı çıkmak için fazla sıcak!");
else if(sıcaklık >= (int)HavaDurumu.Normal && sıcaklık<=(int)HavaDurumu.CokSıcak)
    Console.WriteLine("Hadi çıkalım!");


enum Gunler // default olarak 0'dan başlar.
{
    Pazartesi=1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma=23,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soguk = 5,

    Normal = 20,
    Sıcak = 25,
    CokSıcak = 30
}