using System.IO;

namespace kloserdeneme

{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("yaz");
            string metin = Console.ReadLine();
            
            DateTime gün = DateTime.Today;
            FileAppentText($"c:\\udemy\\MerhabaYeniGün{gün.Day}.{gün.Month}.{gün.Year}.txt", $"{metin}");

            Console.WriteLine("Okumak istediğiniz gününüzü Gün.Ay.Yıl şeklinde giriniz  ");
            DateTime okunacakGün = DateTime.Parse(Console.ReadLine());

            
            

           string metin2= FileReadText($"c:\\udemy\\MerhabaYeniGün{okunacakGün.Day}.{okunacakGün.Month}.{okunacakGün.Year}.txt");
            Console.WriteLine(metin2);
        }



        static void FileAppentText(string path, string deger)
        {

            File.AppendAllText(path, deger);

        }

        static string FileReadText(string path) 
        {
            
            string metinDegeri=File.ReadAllText(path);

            return metinDegeri;

            
        }
    }
}