using BideryaMvcProject.DataBase;
using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.DataBase.Entities.Kullanicilar;
using BideryaMvcProject.Models.Ilanlar.Temizlik;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

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
        public IActionResult KoltukTemizlik()
        {
            var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var UserEmail = User.FindFirstValue(ClaimTypes.Email);
            KoltukTemizlikViewModel koltukTemizlikViewModel = new KoltukTemizlikViewModel();


            var kul = context?.Kullanicis?
            .Include(p => p.KullaniciAdress)
            .FirstOrDefault(p => p.Email == UserEmail && p.Id == int.Parse(UserId));

            var KullaniciAdres = kul.KullaniciAdress?.FirstOrDefault(p => p.KullaniciId == int.Parse(UserId));

            if (KullaniciAdres != null)
            {
                koltukTemizlikViewModel.Il = KullaniciAdres.Il;
                koltukTemizlikViewModel.Ilce = KullaniciAdres.Ilce;
                koltukTemizlikViewModel.AdresGenel = KullaniciAdres.AdresGenel;
            }
            else
            {
                koltukTemizlikViewModel.Il = null;
                koltukTemizlikViewModel.Ilce = null;
                koltukTemizlikViewModel.AdresGenel = null;
            }

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
                    KoltukTemizlik =new DataBase.Entities.Hizmetler.Temizlik.KoltukTemizlik
                    {TeklifSayisi =0,
                    IkiliKoltukSayisi =model.IkiliKoltukSayisi,
                    LKoltukSayisi =model.LKoltukSayisi,
                    MinderSayisi =model.MinderSayisi,
                    TekliKoltukSayisi=model.TekliKoltukSayisi,
                    UcluKoltukSayisi =model.UcluKoltukSayisi,
                    Aciklama =model.Aciklama,
                    


                        SandalyeSayisi =model.SandalyeSayisi,
                        CiftKisilikYatakSayisi =model.CiftKisilikYatakSayisi,
                        TekliYatakSayisi =model.TekliYatakSayisi,
                    }





                } };

                context.Update(kul);
                context.SaveChanges();


                //TODO burada kaldım
            }

            return View();
        }
        public IActionResult EvTemizlik()
        {
            return View();
        }


        public IActionResult AracYikama()
        {
            return View();
        }
        public IActionResult Ilaclama()
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

