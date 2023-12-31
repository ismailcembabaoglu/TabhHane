﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabhHane.Server.Data.Models
{
   public class OdemeTuru 
    {
        public int Id { get; set; }
        public string OdemeTuruKodu { get; set; }
        public string OdemeTuruAdi { get; set; }
        public string Aciklama { get; set; }
        public virtual ICollection<KasaHareket> KasaHareketler { get; set; }
    }
}
