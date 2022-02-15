using System.Collections;

//System.Collections namespaces
//Birden fazla tür saklayabilen dizi türüdür.

ArrayList liste=new ArrayList();
liste.Add("Mahmut");
liste.Add(2);
liste.Add(true);
liste.Add('A');

//İçerisindeki verilere erişim
Console.WriteLine(liste[1]);

foreach(var item in liste)
    Console.WriteLine(item);

//AddRange
Console.WriteLine("***** Add Range *****");
string[] renkler ={"Kırmızı","Sarı","Mavi"};
List<int> sayilar =new List<int>{1,3,9,4,7,6,8};
liste.AddRange(renkler);
liste.AddRange(sayilar);

foreach(var item in liste)
    Console.WriteLine(item);

//Sort
//Console.WriteLine("***** Sort *****");
//liste.Sort(); // Aynı tipteki değişkenler yoksa içinde RunTime da hata verecektir.

Console.WriteLine("**** Binary Search ****");
Console.WriteLine(liste.BinarySearch(9));

//Reverse
Console.WriteLine("**** Reverse ****");
liste.Reverse();
foreach(var item in liste)
    Console.WriteLine(item);

//Clear
liste.Clear();
Console.WriteLine("**** Clear ****");
foreach(var item in liste)
    Console.WriteLine(item);



