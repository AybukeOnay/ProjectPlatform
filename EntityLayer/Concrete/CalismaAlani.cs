using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CalismaAlani
    {
        [Key]
        public int CalismaAlaniID { get; set; }

        [StringLength(50)]
        public string CalismaAlaniTanim { get; set; }

        List<Proje> Projeler { get; set; }
        List<OgretimElemaniCalismaAlani> OgretimElemaniCalismaAlanlari { get; set; }
    }
}
