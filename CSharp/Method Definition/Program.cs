
// Metotlar

//erisim_belirteci geri_donus_tipi metot_adi(parametre Listesi/argüman)
//{
    // komutlar;
    //return;
//}
int a=3;
int b=2;
Console.WriteLine(a+b);
int sonuc= Topla(4,5);
Console.WriteLine(sonuc);



static int Topla(int sayi1,int sayi2)
{
    return(sayi1+sayi2);
}

Metotlar ornek= new Metotlar();
ornek.EkranaYazdir(Convert.ToString(sonuc));

int ornek2=ornek.ArttırVeTopla(ref a,ref b);


class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public int ArttırVeTopla(ref int deger1,ref int deger2)
    {
        deger1+=1;
        deger2+=1;
        return  deger1+ deger2;
        
    }
}
