using BideryaMvcProject.DataBase;
using BideryaMvcProject.DataBase.Entities.Hizmetler.TadilatVeDekorasyon;
using BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik;
using BideryaMvcProject.DataBase.Entities.Ilanlar;
using BideryaMvcProject.DataBase.Entities.Kullanicilar;
using BideryaMvcProject.Helper.IlanHelpers;
using BideryaMvcProject.Models.Ilanlar.TadilatVeDekorasyon;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BideryaMvcProject.Controllers.TadilatVeDekorasyon
{
    public class TadilatVeDekorasyonController : Controller
    {
        private readonly BideryaMvcDatabase? context;
        private readonly IConfiguration configuration;


        public TadilatVeDekorasyonController(BideryaMvcDatabase? context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult TadilatVeDekorasyon()
        {
            return View();
        }
        public IActionResult AhsapMerdiven()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AhsapMerdiven(AhsapMerdivenIsleriViewmodel model)
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

                Kullanici? kul =await context.Kullanicis.FirstOrDefaultAsync(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanBaslik =model.IlanBaslik,


                    Tadilat =new Tadilat()
                    {
                        AltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.AhsapMerdiven),
                        KategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),


                        AhsapMerdivens =new List<AhsapMerdiven>
                        {new AhsapMerdiven()
                        {
                            BasamakSayisi =model.BasamakSayisi,
                            Aciklama =model.Aciklama,
                            IsTuru =model.IsTuru,
                            IlanAltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.AhsapMerdiven),
                            IlanKategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),
                           
                        }
                            
                        }
                    }

                }
                };


                context.Update(kul);
                await context.SaveChangesAsync();

                return View();

            }
        }
        public IActionResult AlciIsleri()
        {
            return View();
        }
        public IActionResult AlcipanIsleri()
        {
            return View();
        }
        public IActionResult AnahtarTeslimInsaaat()
        {
            return View();
        }
        public IActionResult AnahtarTeslimTadilat()
        {
            return View();
        }
        public IActionResult BahceBakimi()
        {
            return View();
        }
        public IActionResult BalkonFilesi()
        {
            return View();
        }

        public IActionResult BanyoTadilat()
        {
            return View();
        }
        public IActionResult BinaGuclendirme()
        {
            return View();
        }
        public IActionResult BoyaBadana()
        {
            return View();
        }
        public IActionResult CamBalkon()
        {
            return View();
        }
        public IActionResult CatiTadilati()
        {
            return View();
        }

        public IActionResult CelikEvYapimi()
        {
            return View();
        }

        public IActionResult CelikKapi()
        {
            return View();
        }
        public IActionResult DogalgazTesisatiVeProjesi()
        {
            return View();
        }
        public IActionResult DemirKaynak()
        {
            return View();
        }
        public IActionResult DepremTesti()
        {
            return View();
        }
        public IActionResult DolapYapimi()
        {
            return View();
        }
        public IActionResult Dusakabin()
        {
            return View();
        }
        public IActionResult DuvarKagidiIsleri()
        {
            return View();
        }

        public IActionResult EpoksiZeminKaplama()
        {
            return View();
        }
        public IActionResult EvDekorasyon()
        {
            return View();
        }
        public IActionResult EvTadilat()
        {
            return View();
        }
        public IActionResult FayansDoseme()
        {
            return View();
        }
        public IActionResult GunesEnerjisi()
        {
            return View();
        }
        public IActionResult HavuzYapimi()
        {
            return View();
        }
        public IActionResult HazirRuloCim()
        {
            return View();
        }
        public IActionResult KabaInsaat()
        {
            return View();
        }
        public IActionResult KapiPencereSinekligi()
        {
            return View();
        }
        public IActionResult KoltukDoseme()
        {
            return View();
        }
        public IActionResult LaminatParkeDoseme()
        {
            return View();
        }
        public IActionResult Mantolama()
        {
            return View();
        }
        public IActionResult MezarYapimi()
        {
            return View();
        }
        public IActionResult MimariProjeCizimi()
        {
            return View();
        }
        public IActionResult MobilyaBoyama()
        {
            return View();
        }
        public IActionResult MutfakDolabiYapimi()
        {
            return View();
        }
        public IActionResult MutfakTadilat()
        {
            return View();
        }
        public IActionResult MutfakTezgahi()
        {
            return View();
        }
        public IActionResult OtomatikKepenk()
        {
            return View();
        }
        public IActionResult OzelMobilyaYapimi()
        {
            return View();
        }
        public IActionResult Panjur()
        {
            return View();
        }
        public IActionResult ParkeSistreCila()
        {
            return View();
        }
        public IActionResult ParkeTasiDoseme()
        {
            return View();
        }
        public IActionResult PrefabrikEvYapimi()
        {
            return View();
        }
        public IActionResult PVCKapiPencereBalkon()
        {
            return View();
        }
        public IActionResult SeramikDoseme()
        {
            return View();
        }
        public IActionResult SesYalitimi()
        {
            return View();
        }
        public IActionResult StorPerde()
        {
            return View();
        }
        public IActionResult SuYalitimi()
        {
            return View();
        }
        public IActionResult SupurgelikMontaji()
        {
            return View();
        }
        public IActionResult SurguluKapi()
        {
            return View();
        }
        public IActionResult TelOrguCiti()
        {
            return View();
        }
        public IActionResult TenteBrandaTadilatVeDekorasyon()
        {
            return View();
        }
    }
}
