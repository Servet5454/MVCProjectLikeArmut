using BideryaMvcProject.DataBase;
using BideryaMvcProject.DataBase.Entities.Kullanicilar;
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
using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult GirisYap(KullaniciGirisyapViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
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
                    TempData["Hesabım"] = "Hesabım";

                    return RedirectToAction("Anasayfa", "Home");
                }
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
        [HttpGet]
        public IActionResult HizmetVerenHesapOlustur()
        {
            return View();
        }


        [HttpPost]
        public IActionResult HizmetVerenHesapOlustur(HesapOlusturViewModel model)
        {
            if (!ModelState.IsValid)//Girilen Bilgiler Hatalı ise burası yapılacak
            {
                //Bilgilerinizde Hata Var Lütfen Bilgileri Doğru Giriniz
                return View();
            }
            else
            {
                HizmetVeren? kullanicicontrol = context?.HizmetVerens?.FirstOrDefault(k => k.Email == model.Email.ToLower());
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
                    //Kayıt İşlemi Yapılacak
                    loginRegisterIslem.HizmetVerenKayitEt(model, hashedsifre1, hashedsifre2);


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
            var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var UserEmail = User.FindFirstValue(ClaimTypes.Email);

            HizmetVeren hizmetVeren = context.HizmetVerens.FirstOrDefault(p => p.Id ==int.Parse(UserId));

            return View();
        }
        [HttpPost]
        public IActionResult HizmetVerenPanel(HesapOlusturViewModel model)
        {
            if (!ModelState.IsValid)//Girilen Bilgiler Hatalı ise burası yapılacak
            {
                //Bilgilerinizde Hata Var Lütfen Bilgileri Doğru Giriniz
                return View();
            }
            else
            {
                HizmetVeren? kullanicicontrol = context?.HizmetVerens?.FirstOrDefault(k => k.Email == model.Email.ToLower());
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
                    //Kayıt İşlemi Yapılacak
                    loginRegisterIslem.HizmetVerenKayitEt(model, hashedsifre1, hashedsifre2);


                    //TODO Kayıt İşlemi Başarılı bir Şekilde Yapıldı Uyarısı Verilecek...
                    return RedirectToAction("Anasayfa", "Home");
                }
                else
                {
                    return View();// Başarısız olunca burası olacak
                }

            }

         
        }
        public IActionResult SifremiUnuttum()
        {
            return View();
        }

        public IActionResult Ilanlarim()
        {
            var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var UserEmail = User.FindFirstValue(ClaimTypes.Email);

            //var ilanlarim =context.Kullanicis.Where(p=>p.Id ==int.Parse(UserId)).Include(p=>p.Ilans).ThenInclude(p=>p.KoltukTemizlik).ToList();

            var ilan =context.Ilans.Where(p=>p.KullaniciId ==int.Parse(UserId)).ToList();
            return View();
        }
        
        

    }
}
