using System.Collections;

Console.WriteLine("Lütfen bir cümle giriniz. ");
string metin = string.Format(Console.ReadLine());
char[] sesli = {'a','e','ı','i','o','ö','u','ü','A','E','I','İ','O','Ö','U','Ü'};

ArrayList sesliharf =new ArrayList();
foreach (var item in metin)
{
    foreach (var j in sesli)
    {
        if(item == j)
        sesliharf.Add(j);   
    }
}
Console.Write("Cümle içindeki sesli harfler: ");
foreach (var i in sesliharf)
{
    Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine($"Cümle içindeki sesli harf sayısı: {sesliharf.Count}");


