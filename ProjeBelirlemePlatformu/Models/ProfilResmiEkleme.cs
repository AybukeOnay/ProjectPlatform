using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBelirlemePlatformu.Models
{
    public class ProfilResmiEkleme
    {
        public int OgretimElemaniID { get; set; }
        public string OgretimElemaniAd { get; set; }
        public string OgretimElemaniSoyad { get; set; }
        public string OgretimElemaniUnvan { get; set; }
        public string OgretimElemaniCinsiyet { get; set; }
        public string OgretimElemaniMail { get; set; }
        public string OgretimElemaniSifre { get; set; }
        public bool OgretimElemaniDurum { get; set; }
        public IFormFile OgretimElemaniResim { get; set; }
        public string OgretimElemaniOzgecmis { get; set; }
    }
}
