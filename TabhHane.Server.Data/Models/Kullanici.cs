﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabhHane.Server.Data.Models
{
   public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Gorevi { get; set; }
        public string Parola { get; set; }
        public string HatirlatmaSorusu { get; set; }
        public string Cevap { get; set; }
        public Nullable<DateTime> KayitTarihi { get; set; }
        public Nullable<DateTime> SonGirisTarihi { get; set; }
        public ICollection<KullaniciRol> KullaniciRols { get; set; }

    }
}
