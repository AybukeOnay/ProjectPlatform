using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Proje
    {
        [Key]
        public int ProjeID { get; set; }

        public int CalismaAlaniID { get; set; }
        public CalismaAlani CalismaAlani { get; set; }

        public int OgretimElemaniID { get; set; }
        public OgretimElemani OgretimElemani { get; set; }

        public int OgrenciID { get; set; }
        public Ogrenci Ogrenci { get; set; }

        [StringLength(100)]
        public string ProjeAd { get; set;}
       
        public DateTime ProjeTarih { get; set; }

        [StringLength(50)]
        public string ProjeTur { get; set; }

        [StringLength(1000)]
        public string ProjeAciklama { get; set; }

        List<Dosya> Dosyalar { get; set; }
    }
}
