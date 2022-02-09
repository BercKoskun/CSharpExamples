// Ekranda girilen sayıya kadar olan tek sayıları ekrana yazdır!

Console.Write("Bir sayı giriniz: ");
int sayac= int.Parse(Console.ReadLine());
for (int i = 1; i < sayac; i++) // i 1'den başlasın sayac'a kadar 1'er artsın   
{
    if(i%2 == 1)
    Console.WriteLine(i);
}


// 1 ile 25 arasındaki rakamların tek ve çift toplamlarını yazdır.
int tekToplam=0;
int ciftToplam=0;
for (int i = 1; i < 25; i++)
{   
    if(i%2 == 1)
        tekToplam += i; // tekToplam + i
    else
        ciftToplam +=i;
}
Console.WriteLine($"Tek Toplam: {tekToplam}");
Console.WriteLine($"Cift Toplam: {ciftToplam}");

// break, continue 
for (int i = 1; i < 10; i++)
{
    if(i==4)
        break; // 4'ü gördüğü anda programı kırar
    Console.WriteLine(i);  
}

for (int i = 1; i < 10; i++)
{
    if(i==4)
        continue; // 4'ü gördüğü anda 4'ü atlar  
    Console.WriteLine(i);
}

