
// Sort -> Dizi Sıralama

int[] sayiDizisi = {23,12,42,54,67};

Console.WriteLine("**** Sırasız Dizi****");
foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);   

Console.WriteLine("**** Sıralı Dizi****");
Array.Sort(sayiDizisi);

foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

// Clear -> Belirlenen elemana 0 atama, temizleme
Console.WriteLine("**** Array Clear****");
Array.Clear(sayiDizisi,2,1);

foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);   

// Reverse -> Diziyi ters çevirme
Console.WriteLine("**** Array Reverse****");
Array.Reverse(sayiDizisi);

foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);   

//IndexOf 
Console.WriteLine("**** Array IndexOf ****");
Console.WriteLine(Array.IndexOf(sayiDizisi,23));

//Resize
Console.WriteLine("**** Array Resize");
Array.Resize(ref sayiDizisi,9);
sayiDizisi[8] = 56;

foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);   









