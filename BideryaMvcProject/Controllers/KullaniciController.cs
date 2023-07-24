using BideryaMvcProject.DataBase;
using BideryaMvcProject.DataBase.Entities.Kullanici;
using BideryaMvcProject.Models.HesapKullanici;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using NETCore.Encrypt.Extensions;

namespace BideryaMvcProject.Controllers
{
    public class KullaniciController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly BideryaMvcDatabase context;

        public KullaniciController(BideryaMvcDatabase context, IConfiguration configuration)
        {
            this.context=context;
            this.configuration=configuration;
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
        public IActionResult HesapOlustur(HesapOlusturViewModel model)
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
                Kullanici? DbKullanici = new Kullanici
                {
                    Sifre1 = hashedsifre1,
                    Sifre2 = hashedsifre2,
                    Ad = model.Ad,
                    Soyad = model.Soyad,
                    Email = model?.Email?.ToLower(),
                    TelNo = model?.TelNo,

                    KullaniciAdress = new List<KullaniciAdres>
                    {

                       new KullaniciAdres
                       {
                            Mahalle ="Mahalle",
                            Adresbasligi ="3. Adresim",
                            Il ="Şehir",
                            Ilce ="İlçe",
                            AdresGenel ="Genel Adres",
                       }

                    }
                };
                context?.Add(DbKullanici);
                context?.SaveChanges();
                //TODO Kayıt İşlemi Başarılı bir Şekilde Yapıldı Uyarısı Verilecek...
                return RedirectToAction("Anasayfa", "Home");
            }
            else
            {
                return View();// Başarısız olunca burası olacak
            }


        }
        public IActionResult CikisYap()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Anasayfa", "Home");
        }

    }
}
