Console.Write("Lütfen Kaç adet sayı girmek istediğinizi sayı ile yazınız: ");
int rakam = Convert.ToInt32(Console.ReadLine());
for (int i=0; i<rakam; i++)
{
    Console.Write($"Lütfen {i+1}. sayıyı giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
        if(sayi%2 ==0)
            Console.WriteLine($"Girmiş Olduğunuz {sayi} rakamı  çift sayıdır.");
        else if (sayi ==0)
            Console.WriteLine("Girmiş Olduğunuz 0 rakamı çift sayıdır");
}

