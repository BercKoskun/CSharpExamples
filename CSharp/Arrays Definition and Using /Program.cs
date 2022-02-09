// Diziler == Aynı tip değişkenleri saklamaya yarar. 0'dan başlar.

string[] renkler = new string[5];
string[] hayvanlar = {"Kedi", "Köpek","Maymun" };


int [] dizi;
dizi = new int[5];

// Dizilere değer atama ve erişim
renkler[0]="Mavi";
hayvanlar[1]="Kuş";
dizi[3]=10;

Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

// Döngülerde diziler kullanımı
// Klavyeden girilen N tane sayının ortalamasını hesaplayan program.

Console.Write("Lütfen Dizinin Eleman Sayısını Giriniz: ");
int arylenght = int.Parse(Console.ReadLine());
int[] arynmbr = new int[arylenght];

for (int i = 0; i < arylenght; i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz.", i+1);
    arynmbr[i] = int.Parse(Console.ReadLine());   
}

int toplam=0;
foreach (var nmbr in arynmbr)
    toplam += nmbr;


Console.WriteLine($"Ortalama: {toplam/arylenght}");







