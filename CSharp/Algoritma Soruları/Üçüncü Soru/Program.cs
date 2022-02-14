Console.Write("Lütfen girmek istediğiniz kelime sayısını yazınız: ");
int kelimesayisi = Convert.ToInt32(Console.ReadLine());
string[] kelimeler = new string[kelimesayisi];
for (int i = 0; i < kelimesayisi; i++)
{
    Console.Write($"Lütfen girmek istediğiniz {i+1}. kelimeyi giriniz: ");
    kelimeler[i] = Console.ReadLine();
}
Array.Reverse(kelimeler);
foreach (var item in kelimeler)
{
    Console.Write(item);   
}
