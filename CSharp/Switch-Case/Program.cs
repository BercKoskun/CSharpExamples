// See https://aka.ms/new-console-template for more information
int month = DateTime.Now.Month;

//Expression
switch(month)
{
    case 1:
        Console.WriteLine("Ocak Ayındasınız.");
        break;

    case 2:
        Console.WriteLine("Şubat Ayındayız");
        break;
    case 4:
        Console.WriteLine("Nisan Ayındasınız");
        break;
    default:
        Console.WriteLine("Veri Yanlış Girildi");
        break;
}

// Mevsimler
switch(month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış");
        break;
    case 5:
    case 3:
    case 4:
        Console.WriteLine("İlkBahar");
        break;
    case 8:
    case 6:
    case 7:
        Console.WriteLine("Yaz");
        break;
    case 11:
    case 9:
    case 10:
        Console.WriteLine("SonBahar");
        break;

    default: /// Mutlaka yer almalı!!
    break;
}


