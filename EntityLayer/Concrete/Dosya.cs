using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Dosya
    {
        [Key]
        public int DosyaID { get; set; }

        [StringLength(100)]
        public string DosyaAd { get; set; }

        [StringLength(100)]
        public string DosyaTur { get; set; }

        public byte[] DosyaVeri { get; set; }

        public int ProjeID { get; set; }
        public Proje Proje { get; set; }
    }
}
