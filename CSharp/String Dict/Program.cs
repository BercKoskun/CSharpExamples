string degisken= "Dersimiz CSharp, Hoşgeldiniz ";
string degisken2="dersimiz CSharp ";

//Length
Console.WriteLine(degisken.Length);

//ToUpper, ToLower
Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());

//Concat
Console.WriteLine(string.Concat(degisken, "Merhaba!"));

//Compare, CompareTo
Console.WriteLine(degisken.CompareTo(degisken2)); // 0,-1,1
Console.WriteLine(string.Compare(degisken,degisken2,true));
Console.WriteLine(string.Compare(degisken,degisken2,false));

//Contains
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
Console.WriteLine(degisken.StartsWith("Merhaba"));
Console.WriteLine(degisken.LastIndexOf("i"));

//IndexOf
Console.WriteLine(degisken.IndexOf("CS"));

//Insert
Console.WriteLine(degisken.Insert(0,"Baba"));
Console.WriteLine(degisken.LastIndexOf("i"));

//PadLeft, PadRight ->
Console.WriteLine(degisken + degisken2.PadLeft(30));
Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
Console.WriteLine(degisken.PadLeft(50) + degisken2);
Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

//Remove
Console.WriteLine(degisken.Remove(10));
Console.WriteLine(degisken.Remove(5,3)); // 5.karakterden başla 3 tane sil

//Replace
Console.WriteLine(degisken.Replace("CSharp","C#"));
Console.WriteLine(degisken.Replace(" ","*"));

//Split
Console.WriteLine(degisken.Split(' ')[1]); //Boşluklara göre böl ve diziye ata. Sonra 2.elemanını getir. (diziler 0dan başlar.)

//Substring
Console.WriteLine(degisken.Substring(4)); // 4. karakterden başla sona kadar getir.
Console.WriteLine(degisken.Substring(4,6)); // 4. karakterden başla 6 tane getir.



