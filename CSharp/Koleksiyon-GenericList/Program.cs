// List<T> class
// System.Collections.Generic
// T -> object türündedir. 

List<int> sayiListesi= new List<int>();
sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(2);
sayiListesi.Add(94);
sayiListesi.Add(467);


List<string> renkListesi =new List<string>();
renkListesi.Add("Mavi");
renkListesi.Add("Kırmızı");
renkListesi.Add("Turuncu");
renkListesi.Add("Siyah");
renkListesi.Add("Beyaz");
renkListesi.Add("Mor");

//Count
Console.WriteLine(renkListesi.Count);
Console.WriteLine(sayiListesi.Count);

//Foreach ve List.ForEach ile elemana erişim
foreach (var sayi in sayiListesi)
    Console.WriteLine(sayi);

foreach (var renk in renkListesi)
    Console.WriteLine(renk);   

sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk=> Console.WriteLine(renk));

//Listeden eleman çıkarma
sayiListesi.Remove(4);
renkListesi.Remove("Beyaz");

sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

//Index'e göre çıkarma

sayiListesi.RemoveAt(0);
renkListesi.RemoveAt(1);
sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

//Liste içerisinde Arama
if(sayiListesi.Contains(10))
    Console.WriteLine("10 Liste içerisinde bulundu");

//Eleman ile index'e erişme
Console.WriteLine(renkListesi.BinarySearch("Mor"));

//Diziyi List'e çevirme
string[] hayvanlar ={"Kedi","Köpek","Kuş"};
List<string> hayvanlarlistesi = new List<string>(hayvanlar);

//Listeyi nasıl temizleriz?
hayvanlarlistesi.Clear();

//List içinde nesne tutmak
List<Kullanıcılar> kullanıcıListesi= new List<Kullanıcılar>();

Kullanıcılar kullanıcı1= new Kullanıcılar();
kullanıcı1.Isim="Ayşe";
kullanıcı1.Soyisim="Balaban";
kullanıcı1.Yas=32;

Kullanıcılar kullanıcı2 = new Kullanıcılar();
kullanıcı2.Isim ="Mahmut";
kullanıcı2.Soyisim="Ekrem";
kullanıcı2.Yas=12;

kullanıcıListesi.Add(kullanıcı1);
kullanıcıListesi.Add(kullanıcı2);

List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
yeniListe.Add(new Kullanıcılar(){
    Isim="Su",
    Soyisim="Akar",
    Yas=63
});

foreach (Kullanıcılar kullanıcı in kullanıcıListesi)
{
    Console.WriteLine($"Kullanıcı İsim: {kullanıcı.Isim}");
    Console.WriteLine($"Kullanıcı İsim: {kullanıcı.Soyisim}");
    Console.WriteLine($"Kullanıcı İsim: {kullanıcı.Yas}");
}







public class Kullanıcılar
{
private string isim;
private string soyisim;
private int yas;

public string Isim { get =>isim; set=> isim=value; }
public string Soyisim { get=> soyisim; set=>soyisim =value; }
public int Yas { get=>yas; set=>yas=value; } 




}








