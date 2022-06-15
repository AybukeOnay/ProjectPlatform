using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CalismaDosya
    {
        [Key]
        public int CalismaDosyaID { get; set; }

        public int ProjeID { get; set; }
        public Proje Proje { get; set; }

        [StringLength(50)]
        public string CalismaDosyaAd { get; set; }

        [StringLength(50)]
        public string CalismaDosyaTur { get; set; }

        [StringLength(100)]
        public string CalismaDosyaVeri { get; set; }
    }
}
