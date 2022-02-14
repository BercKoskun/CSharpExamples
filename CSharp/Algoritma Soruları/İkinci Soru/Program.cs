Console.Write("Lütfen kaç adet rakam girmek istediğinizi yazınız: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Lütfen girdiğiniz sayılar için bölmek istediğiniz sayıyı yazınız: ");
int m = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.Write($"Lütfen {i+1}. sayıyı giriniz: ");
    int sayi=Convert.ToInt32(Console.ReadLine());
        if(sayi % m ==0)
        {
            Console.WriteLine($"{sayi} sayısı {m}'e tam bölünür.");
        }
        else if(sayi ==0)
        {
            Console.WriteLine("Cevap 0'dır.");
        }
        
}

