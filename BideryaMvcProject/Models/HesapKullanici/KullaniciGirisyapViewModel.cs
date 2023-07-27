using System.ComponentModel.DataAnnotations;

namespace BideryaMvcProject.Models.HesapKullanici
{
    public class KullaniciGirisyapViewModel
    {
        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter uzunluğunda olmalıdır.")]
        public string? Sifre1 { get; set; }
        [Required(ErrorMessage = "E-posta alanı zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string? Email { get; set; }
    }
}
