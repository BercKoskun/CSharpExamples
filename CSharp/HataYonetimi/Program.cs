using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try // Güvence alacağımız kod bloğudur.
            {
                Console.WriteLine("Bir Sayı Giriniz");
                int sayi1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Girmiş olduğunuz sayı {sayi1}");
            }
            catch(Exception ex) //Hata durumunda ne yapılmasını istediğimizi yazıyoruz.
            {
                Console.WriteLine($"Hata: {ex.Message.ToString()}");
            }
            finally //Hata alıp almaması önemli değil! Her durumda çalışır.
            {
                Console.WriteLine("İşlem Tamamlandı");
            }

            try
            {
                //int a = int.Parse(null);
                //int a=int.Parse("testke");
                int a=int.Parse("-2000000000000000");
            }
            catch (ArgumentNullException ex)    
            {
                Console.WriteLine("Hata Alındı");
                Console.WriteLine(ex);
            }
            catch(FormatException fex)
            {
                Console.WriteLine("Tip Hatası alındı");
                Console.WriteLine(fex);
            }
            catch(OverflowException ofex)
            {
                Console.WriteLine("Çok Düşük veya Çok Yüksek");
                Console.WriteLine(ofex);
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı");
            }

            
        }
    }
}

