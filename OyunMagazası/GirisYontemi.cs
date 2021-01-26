using System;
using System.Collections.Generic;
using System.Text;

namespace OyunMagazası
{
    class GirisYontemi
    {
        public void HesapOlustur(MusteriBilgileri musteriBilgileri)
        {
            List<MusteriBilgileri> oyuncular = new List<MusteriBilgileri> { musteriBilgileri };
            MusteriBilgileri oyuncu1 = new MusteriBilgileri();
            oyuncu1.TcNo = "00000";
            oyuncu1.Ad = "Timur";
            oyuncu1.Soyad = "Bahri";
            oyuncu1.Nick = "Excalibur :)";
            oyuncu1.Sifre = 000;
            

            GirisYontemi giris = new GirisYontemi();
            giris.GirisYap(oyuncu1);
        }

        public void GirisYap (MusteriBilgileri oyuncu1)
        {
            List<MusteriBilgileri> oyuncular = new List<MusteriBilgileri> { };
            foreach (var bilgiler in oyuncular)
            {
                Console.WriteLine("Kullanıcı adı giriniz");
                Console.WriteLine("Şifrenizi giriniz");
            }
        }
    }
}
