using BideryaMvcProject.DataBase;
using BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik;
using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.DataBase.Entities.Kullanicilar;
using BideryaMvcProject.Models.Ilanlar.Temizlik;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using BideryaMvcProject.Helper.IlanHelpers;

namespace BideryaMvcProject.Controllers.Temizlik
{
    public class TemizlikController : Controller
    {
        private readonly BideryaMvcDatabase? context;
        private readonly IConfiguration configuration;


        public TemizlikController(BideryaMvcDatabase? context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TemizlikHizmetleri()
        {
            return View();
        }
        public IActionResult ApartmanTemizlik()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ApartmanTemizlik(ApartmanTemizlikViewModel model)
        {
            if (!ModelState.IsValid)
            {


                return View();
            }
            else
            {
                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

                Kullanici kul = context.Kullanicis.FirstOrDefault(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,



                    ApartmanTemizliks =new List<ApartmanTemizlik>()
                    {
                     new ApartmanTemizlik
                    {
                    Aciklama =model.Aciklama,
                    DaireSayisi =model.DaireSayisi,
                    CopToplama =model.CopToplama,
                    Aktifmi =true,
                    Il =model.Il,
                    Ilce =model.Ilce,


                     }
                    }
                    }
                };


                context.Update(kul);
                context.SaveChanges();
                return View();
            }
        }
        public IActionResult BosEvTemizligi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BosEvTemizligi(BosEvTemizlikViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // Eksik Bilgiler Var
                return View(model);
            }
            else
            {
                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

                Kullanici kul = context.Kullanicis.FirstOrDefault(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,



                    BosEvTemizliks =new List<BosEvTemizlik>()
                    {
                     new BosEvTemizlik
                    {

                    EvinDurumu =model.EvinDurumu,
                    BanyoSayisi =model.BanyoSayisi,
                    OdaSayisi =model.OdaSayisi,
                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    Aktifmi =true,

                     }

                    }
                    }
                };


                context.Update(kul);
                context.SaveChanges();

                return View();
                //TODO burada kaldım
            }
        }

        public IActionResult CamTemizligi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CamTemizligi(CamTemizlikViewModel model)
        {

            if (!ModelState.IsValid)
            {
                // Eksik Bilgiler Var
                return View(model);
            }
            else
            {
                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

                Kullanici kul = context.Kullanicis.FirstOrDefault(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,

                    CamTemizliks =new List<CamTemizlik>()
                    {
                     new CamTemizlik
                    {

                    Balkon =model.Balkon,
                    EvBuyukluk =model.EvBuyukluk,
                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    Aktifmi =true,


                     }

                    }
                    }
                };


                context.Update(kul);
                context.SaveChanges();

                return View();

            }
        }
        public IActionResult EvdeHaliYikama()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EvdeHaliYikama(EvdeHaliYikamaViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // Eksik Bilgiler Var
                return View(model);
            }
            else
            {
                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

                Kullanici kul = context.Kullanicis.FirstOrDefault(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,



                    EvdeHaliYikamas =new List<EvdeHaliYikama>()
                    {
                     new EvdeHaliYikama
                    {
                    TeklifSayisi =0,
                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    HaliMetrekare =model.HaliMetrekare,
                    LekeCikarma =model.LekeCikarma,
                    Aktifmi =true,


                     }

                    }
                    }
                };


                context.Update(kul);
                context.SaveChanges();

                return View();
                //TODO burada kaldım
            }

        }
        public IActionResult EvdeUtuHizmeti()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EvdeUtuHizmeti(EvdeUtuViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // Eksik Bilgiler Var
                return View(model);
            }
            else
            {
                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

                Kullanici kul = context.Kullanicis.FirstOrDefault(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,



                    EvdeUtus =new List<EvdeUtu>()
                    {
                     new EvdeUtu
                    {
                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    ParcaSayisi =model.ParcaSayisi,
                    Nevresim =model.Nevresim,
                    Aktifmi =true,


                     }

                    }
                    }
                };


                context.Update(kul);
                context.SaveChanges();

                return View();

            }
        }
        public IActionResult EvTemizlik()
        {


            return View();
        }

        [HttpPost]
        public IActionResult EvTemizlik(EvTemizlikViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // Eksik Bilgiler Var
                return View(model);
            }
            else
            {
                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

                Kullanici kul = context.Kullanicis.FirstOrDefault(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,



                    EvTemizliks =new List<EvTemizlik>()
                    {
                     new EvTemizlik
                    {

                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,


                   BanyoSayisi =model.BanyoSayisi,
                   OdaSayisi =model.OdaSayisi,
                   HayvanVarmi =Convert.ToBoolean(model.HayvanVarmi),
                   CalismaSuresi =model.CalismaSuresi,
                   BalkonSayisi =model.BalkonSayisi,
                   Aktifmi =true,
                    }

                    }
                    }
                };


                context.Update(kul);
                context.SaveChanges();

                return View();

            }
        }
        public IActionResult HaliYikama()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HaliYikama(HaliYikamaViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // Eksik Bilgiler Var
                return View(model);
            }
            else
            {
                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

                Kullanici kul = context.Kullanicis.FirstOrDefault(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,



                    HaliYikamas =new List<HaliYikama>()
                    {
                     new HaliYikama
                    {
                    TeklifSayisi =0,

                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    HaliMetrekare =model.HaliMetrekare,
                    LekeCikarma =model.LekeCikarma,
                    Aktifmi =true,


                     }

                    }
                    }
                };


                context.Update(kul);
                context.SaveChanges();

                return View();

            }
        }

        public IActionResult Ilaclama()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Ilaclama(IlaclamaViewModel model)
        {

            if (!ModelState.IsValid)
            {


                return View();
            }
            else
            {
                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

                Kullanici kul = context.Kullanicis.FirstOrDefault(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    

                    Ilaclamas =new List<Ilaclama>()
                    {
                     new Ilaclama
                    {
                    Aciklama = model.Aciklama,
                    HasereTipi = model.HasereTipi,
                    MekanTipi =model.MekanTipi,
                    Metrekare =model.Metrekare,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    Aktifmi =true,
                     }

                    }
                    }
                };

                context.Update(kul);
                context.SaveChanges();
                return View();

                //TODO burada kaldım
            }
        }


        public IActionResult InsaatSonrasiTemizlik()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InsaatSonrasiTemizlik(InsaatSonrasiTemizlikViewModel model)
        {


            if (!ModelState.IsValid)
            {


                return View();
            }
            else
            {
                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

                Kullanici kul = context.Kullanicis.FirstOrDefault(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,

                    InsaatSonrasiTemizliks =new List<InsaatSonrasiTemizlik>()
                    {
                     new InsaatSonrasiTemizlik
                    {
                    Aciklama = model.Aciklama,
                    BanyoSayisi =model.BanyoSayisi,
                    OdaSayisi =model.OdaSayisi,
                    EvinDurumu =model.EvinDurumu,
                    Metrekare =model.Metrekare,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    Aktifmi =true,

                     }

                    }
                    }
                };



                context.Update(kul);
                context.SaveChanges();
                return View();

                //TODO burada kaldım
            }
        }
        public IActionResult IsyeriTemizligi()
        {
            return View();
        }
        public IActionResult IsyeriTemizligi(IsyeriTemizlikViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // Eksik Bilgiler Var
                return View(model);
            }
            else
            {
                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

                Kullanici kul = context.Kullanicis.FirstOrDefault(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,



                    IsyeriTemizliks =new List<IsyeriTemizlik>()
                    {
                     new IsyeriTemizlik
                    {
                    Aciklama =model.Aciklama,
                    IsyeriTipi =model.IsyeriTipi,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    Metrekare =model.Metrekare,
                    Aktifmi =true,

                     }

                    }
                    }
                };


                context.Update(kul);
                context.SaveChanges();

                return View();
            }

        }
        public IActionResult KoltukTemizlik()
        {

            return View();
        }
        [HttpPost]
        public IActionResult KoltukTemizlik(KoltukTemizlikViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // Eksik Bilgiler Var
                return View(model);
            }
            else
            {
                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

                Kullanici kul = context.Kullanicis.FirstOrDefault(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,



                    KoltukTemizliks =new List<KoltukTemizlik>()
                    {
                     new KoltukTemizlik
                    {
                    IkiliKoltukSayisi =model.IkiliKoltukSayisi,
                    MinderSayisi =model.MinderSayisi,
                    TekliKoltukSayisi=model.TekliKoltukSayisi,
                    UcluKoltukSayisi =model.UcluKoltukSayisi,
                    Aciklama =model.Aciklama,
                    SandalyeSayisi =model.SandalyeSayisi,
                    CiftKisilikYatakSayisi =model.CiftKisilikYatakSayisi,
                    TekliYatakSayisi =model.TekliYatakSayisi,
                    Aktifmi =true

                     }

                    }
                    }
                };


                context.Update(kul);
                context.SaveChanges();

                return View();

            }


        }

        public IActionResult KuruTemizleme()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KuruTemizleme(KuruTemizlemeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // Eksik Bilgiler Var
                return View(model);
            }
            else
            {
                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

                Kullanici kul = context.Kullanicis.FirstOrDefault(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,



                    KuruTemizlemes =new List<KuruTemizleme>()
                    {
                     new KuruTemizleme
                    {
                    Ceket =model.Ceket,
                    Gomlek =model.Gomlek,
                    Gelinlik =model.Gelinlik,
                    Mont =model.Mont,
                    Pantalon =model.Pantalon,
                    Yorgan =model.Yorgan,
                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,

                    Aktifmi =true

                     }

                    }
                    }
                };


                context.Update(kul);
                context.SaveChanges();

                return View();

            }

        }
        public IActionResult MermerCilalama()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MermerCilalama(MermerCilalamaViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // Eksik Bilgiler Var
                return View(model);
            }
            else
            {
                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

                Kullanici kul = context.Kullanicis.FirstOrDefault(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,



                    MermerCilalamas =new List<MermerCilalama>()
                    {
                     new MermerCilalama
                    {
                    MekanTipi =model.MekanTipi,
                    Metrekare =model.Metrekare,

                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,

                    Aktifmi =true

                     }

                    }
                    }
                };


                context.Update(kul);
                context.SaveChanges();

                return View();

            }

        }
        public IActionResult StorPerdeYikama()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StorPerdeYikama(StorPerdeViewModel model)
        {

            if (!ModelState.IsValid)
            {
                // Eksik Bilgiler Var
                return View(model);
            }
            else
            {
                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

                Kullanici kul = context.Kullanicis.FirstOrDefault(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,



                    StorPerdeYikamas =new List<StorPerdeYikama>()
                    {
                     new StorPerdeYikama
                    {
                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,

                    Metrekare =model.Metrekare,
                    Kornis =model.Kornis,
                    Adet =model.Adet,

                    Aktifmi =true

                     }

                    }
                    }
                };


                context.Update(kul);
                context.SaveChanges();

                return View();

            }
        }
        public IActionResult YatakYikama()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YatakYikama(YatakYikamaViewModel model)
        {

            if (!ModelState.IsValid)
            {
                // Eksik Bilgiler Var
                return View(model);
            }
            else
            {
                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

                Kullanici kul = context.Kullanicis.FirstOrDefault(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,



                    YatakYikamas =new List<YatakYikama>()
                    {
                     new YatakYikama
                    {

                    CiftKisilikSayisi =model.CiftKisilikSayisi,
                    TekKisilikSayisi=model.TekKisilikSayisi,
                    LekeVarmi =model.LekeVarmi,

                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,

                    Aktifmi =true

                     }

                    }
                    }
                };


                context.Update(kul);
                context.SaveChanges();

                return View();

            }
        }
        public IActionResult YorganYikama()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YorganYikama(YorganYikamaViewModel model)
        {

            if (!ModelState.IsValid)
            {
                // Eksik Bilgiler Var
                return View(model);
            }
            else
            {
                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

                Kullanici kul = context.Kullanicis.FirstOrDefault(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanBaslik =model.IlanBaslik,


                    YorganYikamas =new List<YorganYikama>()
                    {
                     new YorganYikama
                    {
                    CiftKisilikSayisi =model.CiftKisilikSayisi,
                    TekKisilikSayisi =model.TekKisilikSayisi,
                    LekeVarmi=model.LekeVarmi,

                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    
                    Aktifmi =true

                     }

                    }
                    }
                };


                context.Update(kul);
                context.SaveChanges();

                return View();

            }
        }
    }
}

//AnkaraHizmetIlani ilan = new AnkaraHizmetIlani();
//AnkaraIlanKoltukTemizlik koltukIlan = new AnkaraIlanKoltukTemizlik();
//ilan.HizmetTuru =model.HizmetTuru;
//ilan.HizmetAltKategori =model.HizmetAltKategori;
//ilan.HizmetBolge =model.AdresSehir;


//koltukIlan.HizmetTuruId =model.HizmetTuru;
//koltukIlan.HizmetBolge=model.AdresSehir;
//koltukIlan.HizmetAltKategori=model.HizmetAltKategori;
//koltukIlan.SandalyeSayisi=model.Sandalye;
//koltukIlan.TekliYatakSayisi =model.YatakSayi;
//koltukIlan.CiftKisilikYatakSayisi =model.CiftKisilikYatakSayi;
//koltukIlan.IkiliKoltukSayisi =model.IkiliKoltuk;
//koltukIlan.TekliKoltukSayisi=model.TekliKoltuk;
//koltukIlan.UcluKoltukSayisi  =model.UcluKoltuk;
//koltukIlan.SandalyeSayisi =model.Sandalye;
//koltukIlan.MinderSayisi =model.Minder;
//koltukIlan.LKoltukSayisi =model.LKoltuk;
//ilan.TeklifSayisi =model.TeklifSayisi;

//ilan.AnkaraIlanTemizliks.Add(koltukIlan);
//koltukIlan.AnkaraHizmetIlani =ilan;
//context.Add(koltukIlan);
//context.SaveChanges();




//JasonSerilizear serilizear = new JasonSerilizear();
//var jsonlar = serilizear.jsonSehirgetir();

//var ilce = serilizear.jsonIlcegetir();