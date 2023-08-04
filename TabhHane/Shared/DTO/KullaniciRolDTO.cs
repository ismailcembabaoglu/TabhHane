﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabhHane.Shared.DTO
{
    public class KullaniciRolDTO
    {
        public int Id { get; set; }
        public int RootId { get; set; }
        public int ParentId { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string FormAdi { get; set; }
        public string KontrolAdi { get; set; }
        public bool Yetki { get; set; }
    }
}
