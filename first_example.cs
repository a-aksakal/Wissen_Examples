using System;

namespace hastane
{
    class Program
    {
        static void Main(string[] args)
        {
            //elemanları kullanıcı tarafından girilen 10 adet elemanlı bir dizide , en uzun metni , en uzun metnin karakter sayısını bulan uygulama 
            //güzel bir kod çalışması olmuş... Alican

            
            int yas;
            string sikayet;
            string adsoyad;
            int doktormaas = 5000;
            int Ydoktormaas;
            
            for (int i = 0; i <= 5; i++)
            {
                Console.Write("HASTANEMİZE HOSGELDİNİZ.LÜTFEN AD SOYAD GİRİNİZ :");
                adsoyad = Console.ReadLine();
                Console.Write("LÜTFEN YAŞINIZI GİRİNİZ :");
                yas = Convert.ToInt32(Console.ReadLine());
               
            x:
                Console.Write("LÜTFEN SİKAYETİNİZİ YAZINIZ :");
                sikayet = Console.ReadLine();

                string[] bölümler = { "kbb", "dahiliye", "ortopedi", "genel cerrahi", "acil" };
                string[] hastalıklar = { "öksürük", "kas agrısı", "burkulma", "tümör", "yaralanma" };
                string[] doktorlar = { "kbb_HasanBey", "dahiliye_HüseyinBey", "ortopedi_ErhanBey", "cerrah_KemalBey", "Acil_MerveHnm" };


                if (sikayet == "öksürük")
                {
                    Console.WriteLine("öksürük sikayetiniz için sizi KulakBurunBogaz bölümüne yönlendiriyorum");
                    Console.WriteLine("Doktorunuz : kbb_Hasan bey ");

                }
                else if (sikayet == "kas agrısı")

                {
                    Console.WriteLine("kas agrısı sikayetiniz için sizi dahiliye bölümüne yönlendiriyorum ");
                    Console.WriteLine("Doktorunuz : dahiliye_HüseyinBey ");
                }

                else if (sikayet == "burkulma")

                {
                    Console.WriteLine("burkulma sikayetiniz için sizi ortopedi bölümüne yönlendiriyorum ");
                    Console.WriteLine("Doktorunuz : ortopedi_ErhanBey");

                }

                else if (sikayet == "tümör")

                {
                    Console.WriteLine("tümör sikayetiniz için sizi genel cerrahi bölümüne yönlendiriyorum ");
                    Console.WriteLine("Doktorunuz : cerrah_KemalBey ");
                }
                else if (sikayet=="yaralanma")
                {
                    Console.WriteLine("Yaralanma için sizi Acil servis e yönlendiriyorum ");
                    Console.WriteLine("Doktorunuz : Acil_MerveHnm ");
                }
                else
                {
                    Console.WriteLine("Yanlıs Şikayet Secimi!!!!.Lütfen tekrar şkayet giriniz");
                    goto x;
                }
                Ydoktormaas = doktormaas + 50 * i;
                Console.WriteLine(Ydoktormaas);
            }

            Console.ReadKey();






        }
    }
}
