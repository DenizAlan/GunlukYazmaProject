namespace Gunluk_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GunluguAc();

            
        }

        static void GunluguAc()
        {

            Console.Write("Adınız : ");
            string kullanıcıAdı = Console.ReadLine();
            Console.Write("şifreniz: ");
            string inputPass = Console.ReadLine();

            if (kullanıcıAdı == "denid" && inputPass == "1234")
            {
                Console.WriteLine("Hoşgeldin ");
                GunlukKonusuNedir();
            }
            else
            {
                Console.WriteLine("Hatalı bilgi girdiniz,Günlüğün sahibinin siz olduguna emin olabilmem için tekrar giriniz");
                GunluguAc();


            }
        }
        static string GunlukKonusuNedir()
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Bugünün kunusunu yazınız");
            string konu = Console.ReadLine();
            GununİçeriğiniYaz();
            return konu;
           
        }

        static string GununİçeriğiniYaz()
        {
            Console.WriteLine("Gününüzü anlatınız");
            string günİcerigi = Console.ReadLine();
            return günİcerigi;

        }

        static int GununİceriginiOku()
        {
           
            
        }

        static void TarihSec()
        {

           
            int[] tarih=new int[]

            foreach (int i in tarih)
            {
                Console.WriteLine(i);
            }

            


        }
    }
}