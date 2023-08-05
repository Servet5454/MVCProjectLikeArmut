﻿using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class IlaclamaViewModel: IlanAdresGenelBilgi
    {
        public int Id { get; set; }
        public int IlanId { get; set; }
        public int IlanKategoriId { get; set; } = 1;// TEMİZLİK KATEGORİ
        public int IlanAltKategoriId { get; set; }
        public string? HasereTipi { get; set; }
        public int Metrekare { get; set; }
        public string? MekanTipi { get; set; }
        public string? Aciklama { get; set; }

        public string? IlanBaslik { get; set; } = "İlaçlama";

    }
}
