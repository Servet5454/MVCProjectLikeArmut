﻿using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.Temizlik
{
    public class CamTemizlikViewModel :IlanAdresGenelBilgi
    {
        public int Id { get; set; }
        public string? EvBuyukluk { get; set; }
        public string? Balkon { get; set; }



    }
}
