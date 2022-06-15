using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Bildirim
    {
        [Key]
        public int BildirimID { get; set; }
        public string BildirimTur { get; set; }
        public string BildirimSembol { get; set; }
        public string BildirimDetay { get; set; }
        public DateTime BildirimTarih { get; set; }
        public bool BildirimDurum { get; set; }
        public string BildirimRenk { get; set; }
    }
}
