using BideryaMvcProject.DataBase;
using BideryaMvcProject.DataBase.Entities.Hizmetler;
using BideryaMvcProject.DataBase.Entities.Kullanici;
using BideryaMvcProject.Models.HesapKullanici;
using Microsoft.Extensions.Configuration;
using NETCore.Encrypt.Extensions;
using System.Linq.Expressions;

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

        public void HizmetVerenKayitEt(HesapOlusturViewModel model, string hashedsifre1, string hashedsifre2)
        {
            HizmetVeren? DbHizmetVeren = new HizmetVeren
            {
                Sifre1 = hashedsifre1,
                Sifre2 = hashedsifre2,
                Ad = model.Ad,
                Soyad = model.Soyad,
                Email = model?.Email?.ToLower(),
                FirmaIsmi = model?.FirmaIsmi,
                HizmetKategoriId = model.HizmetKategori,
                TelNo = model.TelNo,
                IsTelNo = model.IsTelNo ?? null,
                KayitTarihi = DateTime.Now,
                VergiNo =model.VergiNo,
                SilinmeTarihi = null,
                Sehir = model.Il,
               



                HizmetverenAdress = new List<HizmetVerenAdres>
                {
                    new HizmetVerenAdres
                    {
                        
                        Adresbasligi ="İş Adresim",
                        Il =model.Il,
                        Ilce =model.Ilce,
                        AdresGenel =model.AdresTanimi,
                    }
                    

                },
                               

            };

            switch (DbHizmetVeren.HizmetKategoriId)
            {
                case 1://BurasıTemizlik
                    DbHizmetVeren.HizmetAltKategori = new HizmetAltKategori
                    {
                        AracYikamaIslemi = true,
                        EvTemizlikIslemi = true,
                        IlaclamaIslemi = true,
                        KoltukTemizlikIslemi = true,

                    };
                    break;
                case 2://Burası Tadilat
                    DbHizmetVeren.HizmetAltKategori = new HizmetAltKategori
                    {
                        CamBalkon = true,
                        EvTadilat = true,
                        Mantolama = true,
                        MutfakDolabiYapimi = true,
                    };

                    break; 
                
                case 3:
                    break;
                default:
                    break;
            }

            context?.Add(DbHizmetVeren);
            context?.SaveChanges();

        }
    }
}
//switch (model.HizmetKategori)
//{
//    case 1:// Temizlik işlemleri için yapılacak bölüm
//        // Hizmet Kategori ID 1 için yapılacak işlemler
//        DbHizmetVeren.HizmetKategoris.Add(new HizmetKategori
//        {
//            KategoriId = model.HizmetKategori,
//            HizmetAltKategoris = new List<HizmetAltKategori>
//{
//    new HizmetAltKategori
//    {
//        AracYikamaIslemi =true,
//        EvTemizlikIslemi =true,
//        IlaclamaIslemi=true,
//        KoltukTemizlikIslemi=true,


//        // Hizmet Kategori ID 1 için HizmetAltKategori oluşturulması
//    }
//}
//        });
//        break;

//    case 2:
//        // Hizmet Kategori ID 2 için yapılacak işlemler
//        DbHizmetVeren.HizmetKategoris.Add(new HizmetKategori
//        {
//            KategoriId = model.HizmetKategori,
//            HizmetAltKategoris = new List<HizmetAltKategori>
//{
//    new HizmetAltKategori
//    {
//        CamBalkon =true,
//        EvTadilat =true,
//        Mantolama=true,
//        MutfakDolabiYapimi=true,

//                        }
//}
//        });
//        break;

//    // Diğer durumlar için case'ler ekleyebilirsiniz.

//    default:
//        // Belirli bir case ile eşleşmezse yapılacak işlemler
//        break;
//}