using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Mesaj
    {
        [Key]
        public int MesajID { get; set; }

        public int? GondericiID { get; set; }

        public int? AliciID { get; set; }

        [StringLength(100)]
        public string MesajKonu { get; set; }

        public string MesajIcerik { get; set; }

        public DateTime MesajTarih { get; set; }

        //public Ogrenci gondericiUser { get; set; }

        //public Ogrenci aliciUser { get; set; }
    }
}
