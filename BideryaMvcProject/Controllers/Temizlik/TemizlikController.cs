using BideryaMvcProject.DataBase;
using BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik;
using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.DataBase.Entities.Kullanicilar;
using BideryaMvcProject.Models.Ilanlar.Temizlik;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using BideryaMvcProject.DataBase.IlIlceJson;


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
                    IlanAltKategoriId =model.IlanAltKategoriId,
                    IlanKategoriId =model.IlanKategoriId,
                    IlanAltKategoriBaslik =model.IlanBaslik,


                    Ilaclamas =new List<Ilaclama>()
                    {
                     new Ilaclama
                    {
                    Aciklama = model.Aciklama,
                    HasereTipi = model.HasereTipi,
                    IlanAltKategoriId =model.IlanAltKategoriId,
                    MekanTipi =model.MekanTipi,
                    Metrekare =model.Metrekare,
                    

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
        
        public IActionResult ApartmanTemizlik()
        {
            return View();
        }
        public IActionResult BosEvTemizligi()
        {
            return View();
        }
        public IActionResult CamTemizligi()
        {
            return View();
        }
        public IActionResult EvTemizlik()
        {
            //JasonSerilizear serilizear = new JasonSerilizear();
            //var jsonlar = serilizear.jsonSehirgetir();

            //var ilce = serilizear.jsonIlcegetir();

            return View();
        }

        [HttpPost]
        public IActionResult EvTemizlik(EvTemizlikViewModel model)
        {
            if (!ModelState.IsValid)
            {
                //hatalı giriş 
                return View(model);
            }
            else
            {

                var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var UserEmail = User.FindFirstValue(ClaimTypes.Email);

            }


            return View();
        }

        public IActionResult EvdeHaliYikama()
        {
            return View();
        }
        public IActionResult EvdeUtuHizmeti()
        {
            return View();
        }
        public IActionResult HaliYikama()
        {
            return View();
        }
        public IActionResult InsaatSonrasiTemizlik()
        {
            return View();
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
                    IlanAltKategoriBaslik ="Koltuk Temizlik",


                    KoltukTemizliks =new List<KoltukTemizlik>()
                    {
                     new KoltukTemizlik
                    {
                    TeklifSayisi =0,
                    IkiliKoltukSayisi =model.IkiliKoltukSayisi,
                    LKoltukSayisi =model.LKoltukSayisi,
                    MinderSayisi =model.MinderSayisi,
                    TekliKoltukSayisi=model.TekliKoltukSayisi,
                    UcluKoltukSayisi =model.UcluKoltukSayisi,
                    Aciklama =model.Aciklama,
                    SandalyeSayisi =model.SandalyeSayisi,
                    CiftKisilikYatakSayisi =model.CiftKisilikYatakSayisi,
                    TekliYatakSayisi =model.TekliYatakSayisi,
                    IlanAltKategoriId =2,
                       }

                    }
                    }
                };


                context.Update(kul);
                context.SaveChanges();


                //TODO burada kaldım
            }

            return View();
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

