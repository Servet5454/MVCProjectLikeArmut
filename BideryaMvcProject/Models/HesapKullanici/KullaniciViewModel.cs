using System.ComponentModel.DataAnnotations;

namespace BideryaMvcProject.Models.HesapKullanici
{
    public class KullaniciViewModel
    {
        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        public string? Ad { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunludur.")]
        public string? Soyad { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter uzunluğunda olmalıdır.")]
        public string? Sifre1 { get; set; }

        [Compare("Sifre1", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string? Sifre2 { get; set; }

        [Required(ErrorMessage = "E-posta alanı zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string? Email { get; set; }
    }
}
