using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OgretimElemaniCalismaAlani
    {
        [Key]
        public int OgretimElemaniCalismaAlaniID { get; set; }

        public int OgretimElemaniID { get; set; }
        public OgretimElemani OgretimElemani { get; set; }

        public int CalismaAlaniID { get; set; }
        public CalismaAlani CalismaAlani { get; set; }
    }
}
