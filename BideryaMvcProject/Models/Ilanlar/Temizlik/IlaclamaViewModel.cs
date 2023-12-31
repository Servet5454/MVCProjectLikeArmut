﻿using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class IlaclamaViewModel: IlanAdresGenelBilgi
    {
        
        public string? HasereTipi { get; set; }
        public int Metrekare { get; set; }
        public string? MekanTipi { get; set; }

        public string? IlanBaslik { get; set; } = "İlaçlama";
    }
}
