using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OgretimElemani
    {
        [Key]
        public int OgretimElemaniID { get; set; }

        List<Proje> Projeler { get; set; }
        List<OgretimElemaniCalismaAlani> OgretimElemaniCalismaAlanlari { get; set; }

        [StringLength(50)]
        public string OgretimElemaniAd { get; set; }

        [StringLength(50)]
        public string OgretimElemaniSoyad { get; set; }

        [StringLength(20)]
        public string OgretimElemaniUnvan { get; set; }

        [StringLength(1)]
        public string OgretimElemaniCinsiyet { get; set; }

        [StringLength(30)]
        public string OgretimElemaniMail { get; set; }

        [StringLength(20)]
        public string OgretimElemaniSifre { get; set; }

        public string OgretimElemaniResim { get; set; }

        [StringLength(250)]
        public string OgretimElemaniOzgecmis { get; set; }


        public bool OgretimElemaniDurum { get; set; }
    }
}
