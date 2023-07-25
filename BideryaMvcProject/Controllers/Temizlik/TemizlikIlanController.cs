using BideryaMvcProject.DataBase;
using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.Models.Ilanlar;
using Microsoft.AspNetCore.Mvc;

namespace BideryaMvcProject.Controllers.Temizlik
{
    public class TemizlikIlanController : Controller
    {
        private readonly BideryaMvcDatabase? context;

        public TemizlikIlanController(BideryaMvcDatabase? context)
        {
            this.context=context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KoltukTemizlik()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KoltukTemizlik(KoltukTemizlikViewModel model)
        {

            AnkaraHizmetIlani ilan = new AnkaraHizmetIlani();
            AnkaraIlanKoltukTemizlik koltukIlan = new AnkaraIlanKoltukTemizlik();
            ilan.HizmetTuru =model.HizmetTuru;
            ilan.HizmetAltKategori =model.HizmetAltKategori;
            ilan.HizmetBolge =model.AdresSehir;


            koltukIlan.HizmetTuruId =model.HizmetTuru;
            koltukIlan.HizmetBolge=model.AdresSehir;
            koltukIlan.HizmetAltKategori=model.HizmetAltKategori;
            koltukIlan.SandalyeSayisi=model.Sandalye;
            koltukIlan.TekliYatakSayisi =model.YatakSayi;
            koltukIlan.CiftKisilikYatakSayisi =model.CiftKisilikYatakSayi;
            koltukIlan.IkiliKoltukSayisi =model.IkiliKoltuk;
            koltukIlan.TekliKoltukSayisi=model.TekliKoltuk;
            koltukIlan.UcluKoltukSayisi  =model.UcluKoltuk;
            koltukIlan.SandalyeSayisi =model.Sandalye;
            koltukIlan.MinderSayisi =model.Minder;
            koltukIlan.LKoltukSayisi =model.LKoltuk;
            ilan.TeklifSayisi =model.TeklifSayisi;

            ilan.AnkaraIlanTemizliks.Add(koltukIlan);
            koltukIlan.AnkaraHizmetIlani =ilan;
            context.Add(koltukIlan);
            context.SaveChanges();





            return View();
        }
        public IActionResult EvTemizlik()
        {
            return View();
        }
    }
}
