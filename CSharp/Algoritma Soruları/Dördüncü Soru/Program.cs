Console.Write("Bir Cümle Yazınız: ");
string metin= string.Format(Console.ReadLine());
string metiniki = metin.Trim((new Char[] { ' ', ',', '.' } ));
string[] kelimeler= metiniki.Split(' ');
string liste =  "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                +"abcçdefgğhiıjklmnoöprsştuüvyz"
                + "0123456789";
Console.WriteLine($"Cümledeki kelime adeti: {kelimeler.Length}");
int sayac =0; 
for (int i = 0; i < metin.Length; i++)
{
    if (liste.Contains(metin[i]))
        sayac++;
}
Console.WriteLine($"Cümledeki harf sayısı: {sayac}");


