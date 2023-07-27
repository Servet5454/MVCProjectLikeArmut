using BideryaMvcProject.DataBase;
using BideryaMvcProject.DataBase.Entities.Kullanici;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using NETCore.Encrypt.Extensions;
using BideryaMvcProject.Models.HesapKullanici;
using BideryaMvcProject.DataBase.Entities.Hizmetler;
using BideryaMvcProject.DataBase.Entities.Hizmetler.Temizlik;
using BideryaMvcProject.Helper;

namespace BideryaMvcProject.Controllers
{
    public class KullaniciController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly BideryaMvcDatabase context;

        public KullaniciController(BideryaMvcDatabase context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }


        public IActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GirisYap(HesapOlusturViewModel model)
        {
            string? mD5SifreOnEk = configuration.GetValue<string>("AppSettings:MD5OnEk");
            string paswordSifre = model.Sifre1 + mD5SifreOnEk;
            string hashedsifre1 = paswordSifre.MD5();

            Kullanici? kul = context?.Kullanicis?
                        .FirstOrDefault(p => p.Email == model.Email.ToLower() && p.Sifre1 == hashedsifre1);

            if (kul == null)
            {
                TempData["KullaniciBilgi"] = "Email Adresi yada Şifreniz Hatalı";
                return View("GirisYap", model);
            }

            else
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier, kul.Id.ToString()));
                claims.Add(new Claim(ClaimTypes.Name, kul.Ad ?? string.Empty));
                claims.Add(new Claim(ClaimTypes.Surname, kul.Soyad ?? string.Empty));
                claims.Add(new Claim(ClaimTypes.Email, kul.Email ?? string.Empty));
                claims.Add(new Claim("KullaniciAdi", kul.Ad));
                claims.Add(new Claim("KullaniciEmail", kul.Email.ToLower()));
                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                TempData["Hesabım"] = model.Ad;

                return RedirectToAction("Anasayfa", "Home");
            }

        }
        public IActionResult HesapOlustur()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HesapOlustur(KullaniciViewModel model)
        {
            if (!ModelState.IsValid)//Girilen Bilgiler Hatalı ise burası yapılacak
            {
                //Bilgilerinizde Hata Var Lütfen Bilgileri Doğru Giriniz
                return View();
            }
            else//bilgiler doğru ise burası yapılacak
            {
                Kullanici? kullanicicontrol = context?.Kullanicis?.FirstOrDefault(k => k.Email == model.Email.ToLower());
                if (kullanicicontrol != null)
                {
                    ViewData["information"] = "Sisteme Zaten Kayıtlısınız";
                    return View();// Başarısız olunca burası olacak
                }
                else if (model.Sifre1 == model.Sifre2 && kullanicicontrol == null)//Başarılı ise burası
                {
                    string? mD5SifreOnEk = configuration.GetValue<string>("AppSettings:MD5OnEk");
                    string paswordSifre = model.Sifre1 + mD5SifreOnEk;
                    string hashedsifre1 = paswordSifre.MD5();
                    string paswordsifre2 = model.Sifre2 + mD5SifreOnEk;
                    string hashedsifre2 = paswordsifre2.MD5();


                    LoginRegisterIslem loginRegisterIslem = new();
                    loginRegisterIslem.KullaniciKayitEt(model, hashedsifre1, hashedsifre2);
                    //TODO Kayıt İşlemi Başarılı bir Şekilde Yapıldı Uyarısı Verilecek...
                    return RedirectToAction("Anasayfa", "Home");
                }
                else
                {
                    return View();// Başarısız olunca burası olacak
                }
            }




           


        }
        public IActionResult CikisYap()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Anasayfa", "Home");
        }
        [HttpGet]
        public IActionResult HizmetVerenPanel()
        {


            return View();
        }
        public IActionResult Panel1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult hizmetverenekle(HesapOlusturViewModel model)
        {
            HizmetVeren hizmetVeren = new HizmetVeren
            {
                Ad = model.Ad,
                Soyad = model.Soyad,
                Email = model.Email,
                Sifre1 = model.Sifre1,
                FirmaIsmi = model.FirmaIsmi,
                Sifre2 = model.Sifre2,
            };

            hizmetVeren.HizmetKategoris.Add(new HizmetKategori
            {
                KategoriId = 1,
                HizmetAltKategoris = new HashSet<HizmetAltKategori> { new()
                {
                    AracYikamaIslemi = true,
                    CamBalkon = true,
                    KoltukTemizlikIslemi = true,
                    MutfakDolabiYapimi = true,
                    EvTadilat=true,
                    EvTemizlikIslemi=true,
                    IlaclamaIslemi=true,
                    Mantolama=true,
                   

                } }
            });

           

            context.HizmetVerens.Add(hizmetVeren);
            context.SaveChanges();

            return View();
        }

    }
}
