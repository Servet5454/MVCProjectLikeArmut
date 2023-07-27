using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace BideryaMvcProject.Models.HesapKullanici
{
    public class HesapOlusturViewModel
    {

        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        [MaxLength(100, ErrorMessage = "Ad alanı en fazla 100 karakter olmalıdır.")]
        public string? Ad { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunludur.")]
        [MaxLength(100, ErrorMessage = "Soyad alanı en fazla 100 karakter olmalıdır.")]
        public string? Soyad { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter uzunluğunda olmalıdır.")]
        public string? Sifre1 { get; set; }

        [Compare("Sifre1", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string? Sifre2 { get; set; }

        [Required(ErrorMessage = "E-posta alanı zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Telefon numarası alanı zorunludur.")]
        [RegularExpression(@"^[0-9]{11}$", ErrorMessage = "Telefon Numaranızı Başında Sıfır Olacak Şekilde Yazınız")]
        [MaxLength(11, ErrorMessage = "Telefon numarası en fazla 11 haneli olmalıdır.")]
        public string? TelNo { get; set; }

        public string? IsTelNo { get; set; }
        [Required(ErrorMessage = "Vergi numarası alanı zorunludur.")]
        public string? VergiNo { get; set; }

        [Required(ErrorMessage = "Firma ismi alanı zorunludur.")]
        public string? FirmaIsmi { get; set; }

        [Required(ErrorMessage = "İl alanı zorunludur.")]
        public string? Il { get; set; }

        [Required(ErrorMessage = "İlçe alanı zorunludur.")]
        public string? Ilce { get; set; }

        [Required(ErrorMessage = "Adres tanımı alanı zorunludur.")]
        public string? AdresTanimi { get; set; }
        public int HizmetKategori { get; set; }


    }
}
