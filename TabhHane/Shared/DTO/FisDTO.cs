using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabhHane.Shared.DTO
{
    public class FisDTO
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string FisTuru { get; set; }
        public int? CariId { get; set; }
        public string BelgeNo { get; set; }
        public DateTime? Tarih { get; set; }
        public int? PlasiyerId { get; set; }
        public decimal? IskontoOrani { get; set; }
        public decimal? IskontoTutar { get; set; }
        public decimal? Alacak { get; set; }
        public decimal? Borc { get; set; }
        public decimal? ToplamTutar { get; set; }
        public string Aciklama { get; set; }
        public string FisBaglantiKodu { get; set; }
        public bool DepoIrsaliye { get; set; }
        public int DepoId { get; set; }
        public int? BankaId { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public string YetkiliKisi { get; set; }
        public string FaturaUnvani { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public string Unvani { get; set; }
        public string PersonelKodu { get; set; }
        public string PersonelAdi { get; set; }
        public string HesapKodu { get; set; }
        public string HesapIsmi { get; set; }
        public string Bankasi { get; set; }
        public string Sube { get; set; }
        public string IbanNo { get; set; }
    }
}
