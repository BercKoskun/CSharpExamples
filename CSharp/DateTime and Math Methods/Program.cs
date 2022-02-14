//DateTime Dict
Console.WriteLine(DateTime.Now);

Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddSeconds(30));
Console.WriteLine(DateTime.Now.AddMonths(5));
Console.WriteLine(DateTime.Now.AddYears(10));
Console.WriteLine(DateTime.Now.AddMilliseconds(50));

//DateTime Format
Console.WriteLine(DateTime.Now.ToString("dd")); // günü rakamla getirir.
Console.WriteLine(DateTime.Now.ToString("ddd")); // Sat getirir.
Console.WriteLine(DateTime.Now.ToString("dddd")); // Saturday getirir.

Console.WriteLine(DateTime.Now.ToString("MM")); // ayı rakamla getirir.
Console.WriteLine(DateTime.Now.ToString("MMM")); // Apr getirir
Console.WriteLine(DateTime.Now.ToString("MMMM")); // April olarak getirir.

Console.WriteLine(DateTime.Now.ToString("YY")); // yılın son iki rakamını getirir.
Console.WriteLine(DateTime.Now.ToString("YYYY")); // yılı getirir.

//Math Dict
Console.WriteLine(Math.Abs(-25)); // 25 (Mutlak alır.)
Console.WriteLine(Math.Sin(10));
Console.WriteLine(Math.Cos(10));
Console.WriteLine(Math.Tan(10));

Console.WriteLine(Math.Ceiling(22.3)); // 22.3'ten büyük en küçük tam sayı. 23
Console.WriteLine(Math.Round(22.3)); //yuvarlama 22
Console.WriteLine(Math.Floor(22.5)); // 22.5'ten küçük en büyük tam sayı. 22

Console.WriteLine(Math.Max(2,6));
Console.WriteLine(Math.Min(2,6));

Console.WriteLine(Math.Pow(3,4)); // 3^4 ü verir
Console.WriteLine(Math.Sqrt(9)); // karekök alır
Console.WriteLine(Math.Log(9)); // e tabanındaki logaritmik karşılığını bulur
Console.WriteLine(Math.Exp(3)); // e üzeri 3 ü verir
Console.WriteLine(Math.Log10(10)); // 10 Sayısının logaritma 10 tabanındaki karşılığı



