﻿using BideryaMvcProject.Models.Ilanlar.IlanAdresBilgileri;

namespace BideryaMvcProject.Models.Ilanlar.TadilatVeDekorasyon
{
    public class AhsapMerdivenIsleriViewmodel :IlanAdresGenelBilgi
    {
        public string? IlanBaslik { get; set; } = "Ahşap Merdiven";
        public string? IsTuru { get; set; }
        public string? BasamakSayisi { get; set; }

    }
}
