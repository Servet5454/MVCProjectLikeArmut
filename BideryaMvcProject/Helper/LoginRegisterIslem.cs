using BideryaMvcProject.DataBase;
using BideryaMvcProject.DataBase.Entities.Kullanici;
using BideryaMvcProject.Models.HesapKullanici;
using Microsoft.Extensions.Configuration;
using NETCore.Encrypt.Extensions;

namespace BideryaMvcProject.Helper
{
    public class LoginRegisterIslem
    {
        BideryaMvcDatabase context = new BideryaMvcDatabase();




        public void KullaniciKayitEt(KullaniciViewModel model, string hashedsifre1, string hashedsifre2)
        {


            Kullanici? DbKullanici = new Kullanici
            {
                Sifre1 = hashedsifre1,
                Sifre2 = hashedsifre2,
                Ad = model.Ad,
                Soyad = model.Soyad,
                Email = model?.Email?.ToLower(),
                

                KullaniciAdress = new List<KullaniciAdres>
                    {

                       new KullaniciAdres
                       {
                            Mahalle ="Mahalle",
                            Adresbasligi ="1. Adresim",
                            Il ="Şehir",
                            Ilce ="İlçe",
                            AdresGenel ="Genel Adres",
                       }

                    }
            };
            context?.Add(DbKullanici);
            context?.SaveChanges();

        }

        public void HizmetVerenKayitEt(HesapOlusturViewModel model, int HizmetKategori)
        {


            switch (HizmetKategori)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                case 6:

                    break;
            }




        }
    }
}
