using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabhHane.Shared.DTO
{
    public class BankaHareketDTO
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string Hareket { get; set; }
        public int BankaId { get; set; }
        public Nullable<int> CariId { get; set; }
        public Nullable<DateTime> Tarih { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public string Aciklama { get; set; }
        public string HesapKodu { get; set; }
        public string HesapIsmi { get; set; }
        public string Bankasi { get; set; }
        public string Sube { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public string YetkiliKisi { get; set; }
        public string FaturaUnvani { get; set; }
    }
}
