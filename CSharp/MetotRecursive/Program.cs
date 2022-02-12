
// Recursive (Refürsif) - Öz yinelemeli (En çok kullanılan alan üssel ifadeler)

// 3^4 = 3*3*3*3



// Faktöriyel almak (For Loop ile)
// Aşağıdaki döngüdeki "int i" ifadesi işlemi kaç kere döndüreceğini ifade eder.
int result=1;
for (int i = 1; i < 5; i++)
{
    result=result*3;
}
Console.WriteLine(result);

Islemler islem = new Islemler();
Console.WriteLine(islem.Expo(5,3));
Console.WriteLine(islem.Expo(0,122));

// Extension Metotlar
string ifade ="Berk Coskun";
bool sonuc = ifade.CheckSpaces();
Console.WriteLine(sonuc);

if(sonuc)
    Console.WriteLine(ifade.RemoveWhiteSpaces());
Console.WriteLine(ifade.MakeUpperCase());
Console.WriteLine(ifade.MakeLowerCase());

int[] dizi= {7,2,8,5,9,1,4,6};
dizi.SortArray();
dizi.EkranaYazdir();

int sayi=5;

Console.WriteLine(sayi.IsEvenNumber());
Console.WriteLine(ifade.GetFirstCharacter());

class Islemler
{
    public int Expo(int sayi, int üs)
    {
        if(üs<2)
        {
            return sayi;
        }
        else if(sayi== 0)
        {
            return 1;
        }
        return Expo(sayi,üs-1)*sayi;
    }
}
public static class Extension // instance almasına gerek yoktur.
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains("");
    }
    public static string RemoveWhiteSpaces(this string param)
    {
        string[ ] dizi = param.Split(" ");
        return string.Join("",dizi);
    }
    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }
    public static int[] SortArray (this int[] param)
    {
        Array.Sort(param);
        return param;
    }
    public static void EkranaYazdir(this int[] param)
    {
        foreach (int item in param)
        {   
            Console.WriteLine(item);   
        }
    }

    public static bool IsEvenNumber(this int param)
    {
        return param%2==0;
    }
    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0,1);
    }
    

}

