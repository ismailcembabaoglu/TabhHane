﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabhHane.Server.Data.Models
{
   public class Banka
    {
        public int Id { get; set; }
        public string HesapKodu { get; set; }
        public string HesapIsmi { get; set; }
        public string Bankasi { get; set; }
        public string Sube { get; set; }
        public string IbanNo { get; set; }
        public string HesapNo { get; set; }
        public string YetkiliAdi { get; set; }
        public string YetkiliTelefonu { get; set; }
        public virtual ICollection<BankaHareket> BankaHareket { get; set; }
        public virtual ICollection<Fis> Fis { get; set; }

    }
}
