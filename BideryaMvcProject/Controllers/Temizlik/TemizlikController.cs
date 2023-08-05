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
        public IActionResult ApartmanTemizlik()
        {
            var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var UserEmail = User.FindFirstValue(ClaimTypes.Email);

            var liste = context.Ilans.Where(p => p.KullaniciId ==int.Parse(UserId)).ToList();
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
                    KullaniciId = int.Parse(UserId),
                    IlanAltKategoriId =model.IlanAltKategoriId,
                    IlanKategoriId =model.IlanKategoriId,
                    IlanBaslik =model.IlanBaslik,


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
                    KullaniciId = int.Parse(UserId),
                    IlanAltKategoriId =2,
                    IlanKategoriId =1,
                    IlanBaslik =model.IlanBaslik,


                    BosEvTemizliks =new List<BosEvTemizlik>()
                    {
                     new BosEvTemizlik
                    {
                    TeklifSayisi =0,
                    IlanAltKategoriId =Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.BosEvTemizligi),
                    EvinDurumu =model.EvinDurumu,
                    BanyoSayisi =model.BanyoSayisi,
                    OdaSayisi =model.OdaSayisi,
                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanKategoriId =Convert.ToInt32(AltKategoriEnum.IlanKategori.Temizlik),
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
                    KullaniciId = int.Parse(UserId),
                    IlanAltKategoriId =2,
                    IlanKategoriId =1,
                    IlanBaslik =model.IlanBaslik,


                    CamTemizliks =new List<CamTemizlik>()
                    {
                     new CamTemizlik
                    {
                    TeklifSayisi =0,
                    IlanAltKategoriId =Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.BosEvTemizligi),
                    Balkon =model.Balkon,
                    EvBuyukluk =model.EvBuyukluk,
                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanKategoriId =Convert.ToInt32(AltKategoriEnum.IlanKategori.Temizlik),
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
                    KullaniciId = int.Parse(UserId),
                    IlanAltKategoriId =2,
                    IlanKategoriId =1,
                    IlanBaslik =model.IlanBaslik,


                    EvdeHaliYikamas =new List<EvdeHaliYikama>()
                    {
                     new EvdeHaliYikama
                    {
                    TeklifSayisi =0,
                    IlanAltKategoriId =Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.BosEvTemizligi),
                    //
                    //
                    //
                    //
                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanKategoriId =Convert.ToInt32(AltKategoriEnum.IlanKategori.Temizlik),
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
                    KullaniciId = int.Parse(UserId),
                    IlanAltKategoriId =2,
                    IlanKategoriId =1,
                    IlanBaslik =model.IlanBaslik,


                    EvdeUtus =new List<EvdeUtu>()
                    {
                     new EvdeUtu
                    {
                    TeklifSayisi =0,
                    IlanAltKategoriId =Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.BosEvTemizligi),
                    //
                    //
                    //
                    //
                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanKategoriId =Convert.ToInt32(AltKategoriEnum.IlanKategori.Temizlik),
                    Aktifmi =true,
                    ParcaSayisi =model.ParcaSayisi,
                    Nevresim =model.Nevresim,
                    
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
                    KullaniciId = int.Parse(UserId),
                    IlanAltKategoriId =2,
                    IlanKategoriId =1,
                    IlanBaslik =model.IlanBaslik,


                    EvTemizliks =new List<EvTemizlik>()
                    {
                     new EvTemizlik
                    {
                    TeklifSayisi =0,
                    IlanAltKategoriId =Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.BosEvTemizligi),
                    //
                    //
                    //
                    //
                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanKategoriId =Convert.ToInt32(AltKategoriEnum.IlanKategori.Temizlik),
                    Aktifmi =true,
                   BanyoSayisi =model.BanyoSayisi,
                   OdaSayisi =model.OdaSayisi,
                   HayvanVarmi =Convert.ToBoolean(model.HayvanVarmi),
                   CalismaSuresi =model.CalismaSuresi,
                   BalkonSayisi =model.BalkonSayisi,


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
                    KullaniciId = int.Parse(UserId),
                    IlanAltKategoriId =2,
                    IlanKategoriId =1,
                    IlanBaslik =model.IlanBaslik,


                    HaliYikamas =new List<HaliYikama>()
                    {
                     new HaliYikama
                    {
                    TeklifSayisi =0,
                    IlanAltKategoriId =Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.HaliYikama),
                    //
                    //
                    //
                    //
                    Aciklama =model.Aciklama,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanKategoriId =Convert.ToInt32(AltKategoriEnum.IlanKategori.Temizlik),
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
                    KullaniciId = int.Parse(UserId),
                    IlanAltKategoriId =Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.Ilaclama
                    ),
                    IlanBaslik =model.IlanBaslik,
                    



                    Ilaclamas =new List<Ilaclama>()
                    {
                     new Ilaclama
                    {
                    Aciklama = model.Aciklama,
                    HasereTipi = model.HasereTipi,
                    IlanAltKategoriId =Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.Ilaclama),
                    MekanTipi =model.MekanTipi,
                    Metrekare =model.Metrekare,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanKategoriId =1,

                    

                     }

                    }
                    }
                };
                AltKategoriEnum enumcik = new AltKategoriEnum();


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
                    KullaniciId = int.Parse(UserId),
                    IlanAltKategoriId =Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.InsaatSonrasiTemizlik
                    ),
                    IlanBaslik =model.IlanBaslik,




                    InsaatSonrasiTemizliks =new List<InsaatSonrasiTemizlik>()
                    {
                     new InsaatSonrasiTemizlik
                    {
                    Aciklama = model.Aciklama,                   
                    IlanAltKategoriId =Convert.ToInt32(AltKategoriEnum.TemizlikAltKategori.InsaatSonrasiTemizlik),
                    BanyoSayisi =model.BanyoSayisi,
                    OdaSayisi =model.OdaSayisi,
                    EvinDurumu =model.EvinDurumu,
                    
                    Metrekare =model.Metrekare,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanKategoriId =1,
                    

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
        public IActionResult KoltukTemizlik()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("GirisYap", "Kullanici");
            }
            var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var UserEmail = User.FindFirstValue(ClaimTypes.Email);
            KoltukTemizlikViewModel koltukTemizlikViewModel = new KoltukTemizlikViewModel();


            var kul = context?.Kullanicis?
            .Include(p => p.KullaniciAdress)
            .FirstOrDefault(p => p.Email == UserEmail && p.Id == int.Parse(UserId));
            var ilanlar = context.Ilans//TODO Bu Sorun Çözülecek
              .Include(i => i.KoltukTemizliks)
              .Include(i => i.EvTadilats)
              .Include(i => i.Mantolamas)
              .Where(i => i.IlanAltKategoriId == 2)
              .ToList();

            var KullaniciAdres = kul.KullaniciAdress?.FirstOrDefault(p => p.KullaniciId == int.Parse(UserId));

            if (KullaniciAdres != null)
            {
                koltukTemizlikViewModel.Il = KullaniciAdres.Il ?? null;
                koltukTemizlikViewModel.Ilce = KullaniciAdres.Ilce ?? null;
                koltukTemizlikViewModel.AdresGenel = KullaniciAdres.AdresGenel ?? null;
            }
            //else
            //{
            //    koltukTemizlikViewModel.Il = null;
            //    koltukTemizlikViewModel.Ilce = null;
            //    koltukTemizlikViewModel.AdresGenel = null;
            //}

            return View(koltukTemizlikViewModel);
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
                    KullaniciId = int.Parse(UserId),
                    IlanAltKategoriId =2,
                    IlanKategoriId =1,
                    IlanBaslik =model.IlanBaslik,


                    KoltukTemizliks =new List<KoltukTemizlik>()
                    {
                     new KoltukTemizlik
                    {
                    TeklifSayisi =0,
                    IkiliKoltukSayisi =model.IkiliKoltukSayisi,
                    MinderSayisi =model.MinderSayisi,
                    TekliKoltukSayisi=model.TekliKoltukSayisi,
                    UcluKoltukSayisi =model.UcluKoltukSayisi,
                    Aciklama =model.Aciklama,
                    SandalyeSayisi =model.SandalyeSayisi,
                    CiftKisilikYatakSayisi =model.CiftKisilikYatakSayisi,
                    TekliYatakSayisi =model.TekliYatakSayisi,
                   
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

        public IActionResult KuruTemizleme()
        {
            return View();
        }
        public IActionResult MermerCilalama()
        {
            return View();
        }
        public IActionResult StorPerdeYikama()
        {
            return View();
        }
        public IActionResult YatakYikama()
        {
            return View();
        }
        public IActionResult YorganYikama()
        {
            return View();
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