using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabhHane.Shared.DTO
{
    public class StokHareketDTO
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string FisBaglantiKodu { get; set; }
        public string Hareket { get; set; }
        public int StokId { get; set; }
        public Nullable<decimal> Miktar { get; set; }
        public int Kdv { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public Nullable<decimal> AlisFiyati { get; set; }
        public Nullable<decimal> AlisFiyati2 { get; set; }
        public Nullable<decimal> AlisFiyati3 { get; set; }
        public Nullable<decimal> IndirimOrani { get; set; }
        public Nullable<decimal> ToplamTutar { get; set; }
        public Nullable<decimal> MevcutStok { get; set; }
        public Nullable<decimal> SayimMiktari { get; set; }

        public int DepoId { get; set; }

        public string SeriNo { get; set; }
        public Nullable<DateTime> Tarih { get; set; }
        public bool Siparis { get; set; }
        public bool Irsaliye { get; set; }
        public bool Teklif { get; set; }
        public string Aciklama { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string Barkod { get; set; }
        public string BarkodTuru { get; set; }
        public string Birimi { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
    }
}
