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

                Kullanici? kul = await context.Kullanicis.FirstOrDefaultAsync(p => p.Id ==int.Parse(UserId));

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
                            IlanBaslik =model.IlanBaslik,
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
        [HttpPost]
        public async Task<IActionResult> AlciIsleri(AlciIsleriViewModel model)
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

                Kullanici? kul = await context.Kullanicis.FirstOrDefaultAsync(p => p.Id ==int.Parse(UserId));

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


                        AlciIsleris =new List<AlciIsleri>
                        {new AlciIsleri()
                        {
                            IlanAltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.AlciIsleri),
                            IlanKategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),
                            Aciklama =model.Aciklama,
                            ExtraHizmet =model.ExtraHizmet,
                            Malzeme =model.Malzeme,
                            Metrekare =model.Metrekare,
                            IlanBaslik =model.IlanBaslik,
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
        public IActionResult AlcipanIsleri()
        {

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> AlcipanIsleri(AlcipanIsleriViewModel model)
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

                Kullanici? kul = await context.Kullanicis.FirstOrDefaultAsync(p => p.Id ==int.Parse(UserId));

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


                        AlcipanIsleris =new List<AlcipanIsleri>
                        {new AlcipanIsleri()
                        {
                            IlanAltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.AlciIsleri),
                            IlanKategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),
                            Aciklama =model.Aciklama,
                            ExtraHizmet =model.ExtraHizmet,
                            Malzeme =model.Malzeme,
                            Metrekare =model.Metrekare,
                            IlanBaslik =model.IlanBaslik,
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
        public IActionResult AnahtarTeslimInsaaat()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AnahtarTeslimInsaaat(AnahtarTeslimInsaatViewModel model)
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

                Kullanici? kul = await context.Kullanicis.FirstOrDefaultAsync(p => p.Id ==int.Parse(UserId));

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


                        AnahtarTeslimInsaats =new List<AnahtarTeslimInsaat>
                        {new AnahtarTeslimInsaat()
                        {
                            IlanAltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.AnahtarTeslimInsaaat),
                            IlanKategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),
                            Aciklama =model.Aciklama,
                            OdemeSekli =model.OdemeSekli,
                            ArsaDurumu =model.ArsaDurumu,
                            BinaMalzemesi =model.BinaMalzemesi,
                            Daire =model.Daire,
                            ImarIzni =model.ImarIzni,
                            MalzemeKalitesi =model.MalzemeKalitesi,
                            ProjeCizimi =model.ProjeCizimi,
                            TabanAlani =model.TabanAlani,
                            Kat =model.Kat,
                            IlanBaslik =model.IlanBaslik,
                            

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
        public IActionResult AnahtarTeslimTadilat()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AnahtarTeslimTadilat(AnahtarTeslimTadilatViewModel model)
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

                Kullanici? kul = await context.Kullanicis.FirstOrDefaultAsync(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanBaslik =model.IlanBaslik,


                    Tadilat =new Tadilat()
                    {
                        AltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.AnahtarTeslimTadilat),
                        KategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),


                        AnahtarTeslimTadilats =new List<AnahtarTeslimTadilat>
                        {new AnahtarTeslimTadilat()
                        {
                            IlanAltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.AnahtarTeslimTadilat),
                            IlanKategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),
                            Aciklama =model.Aciklama,
                            IlanBaslik =model.IlanBaslik,
                            Malzeme =model.Malzeme,
                            Metrekare =model.Metrekare,
                            Tur =model.Tur,                           

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
        public IActionResult BahceBakimi()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BahceBakimi(BahceBakimiViewModel model)
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

                Kullanici? kul = await context.Kullanicis.FirstOrDefaultAsync(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanBaslik =model.IlanBaslik,


                    Tadilat =new Tadilat()
                    {
                        AltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.BahceBakimi),
                        KategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),


                        BahceBakimis =new List<BahceBakimi>
                        {new BahceBakimi()
                        {
                            IlanAltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.BahceBakimi),
                            IlanKategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),
                            Aciklama =model.Aciklama,
                            Sulama =model.Sulama,
                            HangiSiklik =model.HangiSiklik,
                            BakimTuru =model.BakimTuru,
                            IlanBaslik =model.IlanBaslik,
                            Metrekare =model.Metrekare,
                            
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
        public IActionResult BalkonFilesi()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BalkonFilesi(BalkonFilesiViewModel model)
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

                Kullanici? kul = await context.Kullanicis.FirstOrDefaultAsync(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanBaslik =model.IlanBaslik,


                    Tadilat =new Tadilat()
                    {
                        AltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.BalkonFilesi),
                        KategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),


                        BalkonFilesis =new List<BalkonFilesi>
                        {new BalkonFilesi()
                        {
                            IlanAltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.BalkonFilesi),
                            IlanKategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),
                            Aciklama =model.Aciklama,
                            IlanBaslik =model.IlanBaslik,
                            Metrekare =model.Metrekare,
                            Tur =model.Tur,



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

        public IActionResult BanyoTadilat()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BanyoTadilat(BanyoTadilatViewModel model)
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

                Kullanici? kul = await context.Kullanicis.FirstOrDefaultAsync(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanBaslik =model.IlanBaslik,


                    Tadilat =new Tadilat()
                    {
                        AltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.BanyoTadilat),
                        KategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),


                        BanyoTadilats =new List<BanyoTadilat>
                        {new BanyoTadilat()
                        {
                            IlanAltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.BanyoTadilat),
                            IlanKategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),
                            Aciklama =model.Aciklama,
                            IlanBaslik =model.IlanBaslik,
                            Malzeme =model.Malzeme,
                            Metrekare =model.Metrekare,
                            Tur =model.Tur,

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
        public IActionResult BinaGuclendirme()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BinaGuclendirme(BinaGuclendirmeViewModel model)
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

                Kullanici? kul = await context.Kullanicis.FirstOrDefaultAsync(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanBaslik =model.IlanBaslik,


                    Tadilat =new Tadilat()
                    {
                        AltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.BinaGuclendirme),
                        KategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),


                        BinaGuclendirmes =new List<BinaGuclendirme>
                        {new BinaGuclendirme()
                        {
                            IlanAltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.BinaGuclendirme),
                            IlanKategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),
                            Aciklama =model.Aciklama,
                            BlokSayisi =model.BlokSayisi,
                            KatSayisi =model.KatSayisi,
                            IlanBaslik =model.IlanBaslik,
                            TabanAlani =model.TabanAlani,
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
        public IActionResult BoyaBadana()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BoyaBadana(BoyaBadanaViewModel model)
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

                Kullanici? kul = await context.Kullanicis.FirstOrDefaultAsync(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanBaslik =model.IlanBaslik,


                    Tadilat =new Tadilat()
                    {
                        AltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.BoyaBadana),
                        KategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),


                        BoyaBadanas =new List<BoyaBadana>
                        {new BoyaBadana()
                        {
                            IlanAltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.BoyaBadana),
                            IlanKategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),
                            Aciklama =model.Aciklama,
                            OdaSayisi =model.OdaSayisi,
                            EvinDurumu =model.EvinDurumu,
                            IlanBaslik =model.IlanBaslik,
                            Malzeme =model.Malzeme,
                            Metrekare =model.Metrekare,
                            Tavan =model.Tavan,
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
        public IActionResult CamBalkon()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CamBalkon(CamBalkonViewModel model)
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

                Kullanici? kul = await context.Kullanicis.FirstOrDefaultAsync(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanBaslik =model.IlanBaslik,


                    Tadilat =new Tadilat()
                    {
                        AltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.CamBalkon),
                        KategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),


                        CamBalkons =new List<CamBalkon>
                        {new CamBalkon()
                        {
                            IlanAltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.CamBalkon),
                            IlanKategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),
                            Aciklama =model.Aciklama,


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
        public IActionResult CatiTadilati()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CatiTadilati(CatiTadilatiViewModel model)
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

                Kullanici? kul = await context.Kullanicis.FirstOrDefaultAsync(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanBaslik =model.IlanBaslik,


                    Tadilat =new Tadilat()
                    {
                        AltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.CatiTadilati),
                        KategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),


                        CatiTadilatis =new List<CatiTadilati>
                        {new CatiTadilati()
                        {
                            IlanAltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.CatiTadilati),
                            IlanKategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),
                            Aciklama =model.Aciklama,
                            IlanBaslik =model.IlanBaslik,                            


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
        public IActionResult CelikEvYapimi()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CelikEvYapimi(CelikEvYapimiViewModel model)
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

                Kullanici? kul = await context.Kullanicis.FirstOrDefaultAsync(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanBaslik =model.IlanBaslik,


                    Tadilat =new Tadilat()
                    {
                        AltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.CelikEvYapimi),
                        KategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),
                        

                        CelikEvYapimis =new List<CelikEvYapimi>
                        {new CelikEvYapimi()
                        {
                            IlanAltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.CelikEvYapimi),
                            IlanKategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),
                            Aciklama =model.Aciklama,
                            IlanBaslik =model.IlanBaslik,


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

        public IActionResult CelikKapi()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CelikKapi(CelikKapiViewModel model)
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

                Kullanici? kul = await context.Kullanicis.FirstOrDefaultAsync(p => p.Id ==int.Parse(UserId));

                kul.Ilans =new List<Ilan>() { new Ilan
                {
                    AdresDetay =model.AdresGenel,
                    Il =model.Il,
                    Ilce =model.Ilce,
                    IlanBaslik =model.IlanBaslik,


                    Tadilat =new Tadilat()
                    {
                        AltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.CelikKapi),
                        KategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),


                        CelikEvYapimis =new List<CelikEvYapimi>
                        {new CelikEvYapimi()
                        {
                            IlanAltKategoriId =Convert.ToInt16(AltKategoriEnum.TadilatVeDekorasyonHizmetleri.CelikEvYapimi),
                            IlanKategoriId =Convert.ToInt16(AltKategoriEnum.IlanKategori.TadilatVeDekorasyon),
                            Aciklama =model.Aciklama,
                            IlanBaslik =model.IlanBaslik,


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
