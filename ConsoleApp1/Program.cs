using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        

       
        
            string[] dosya = Directory.GetFiles("C:\\Günlük");

            for (int i = 0; i < dosya.Length; i++)
            {
                Console.WriteLine(dosya[i]);
            }

           


        }


    }
}