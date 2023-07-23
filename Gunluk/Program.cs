
using System.IO;
namespace Gunluk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SifreGir();
        }

        static void SifreGir()
        {
            Console.Write("Adınız : ");
            string inputkullanıcıAdı = Console.ReadLine();
            Console.Write("şifreniz: ");
            string inputPass = Console.ReadLine();
            if (inputkullanıcıAdı == "denid" && inputPass == "1234")
            {
                GunluguAc();
            }
            else
            {
                Console.WriteLine("Hatalı bilgi girdiniz,Günlüğün sahibinin siz olduguna emin olabilmem için tekrar giriniz");
                SifreGir();
            }
        }


        static void GunluguAc()
        {    
                Console.WriteLine("");
                
                Console.WriteLine("Günlüğe yazmak için 1'e ,günlüğü okumak için 2'ye  , kapatmak için 3 e basınız ");
                int inputokuVeyaYaz=int.Parse(Console.ReadLine());
                if (inputokuVeyaYaz == 1)
                {
                    string içerik= GunlukYaz();
                    DateTime gün = DateTime.Today;
                    FileAppentText($"c:\\Günlük\\Merhaba Bugün.{gün.Day}.{gün.Month}.{gün.Year}.txt", $"{içerik}");
                GunluguAc();
                   
                }
                else if (inputokuVeyaYaz == 2)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Geçmişte yazdıgınız günlerin listesi  ");
                    Console.WriteLine(" ");

                    string[] dosya = Directory.GetFiles("C:\\Günlük");
                    for (int i = 0; i < dosya.Length; i++)
                    {
                        Console.WriteLine(dosya[i]);
                        
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Okumak istediğiniz gününüzü Gün.Ay.Yıl şeklinde giriniz  ");
                    DateTime inputOkunacakGün = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine($"İşte {inputOkunacakGün} tarihinde olanlar ");
                Console.WriteLine("");
                string metin2 = FileReadText($"c:\\Günlük\\Merhaba Bugün.{inputOkunacakGün.Day}.{inputOkunacakGün.Month}.{inputOkunacakGün.Year}.txt");
                    Console.WriteLine(metin2);
                GunluguAc();
                }
                else
                {
                    Console.WriteLine("Günlerini yazmak için yine gel");
                }
            
            
        }

        static string GunlukYaz()
        {
            Console.WriteLine("");
            Console.WriteLine("Bugünün Konusu Nedir");
            string inputKonu = Console.ReadLine();
            Console.WriteLine("Bugün olanları anlatır mısın? ");
            string inputGününOlayları = Console.ReadLine();
            string bugunOlanlar = "Bugünün Konusu : " + inputKonu + "\n" + "\n" + inputGününOlayları;

            return bugunOlanlar;
        }

        static void FileAppentText(string path, string deger)
        {

            File.AppendAllText(path, deger);

        }

        static string FileReadText(string path)
        {

            string metinDegeri = File.ReadAllText(path);

            return metinDegeri;

        }

        
    }
}