using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ogrenci
    {
        [Key]
        public int OgrenciID { get; set; }        

        [StringLength(20)]
        public string OgrenciAd { get; set; }

        [StringLength(20)]
        public string OgrenciSoyad { get; set; }

        [StringLength(1)]
        public string OgrenciCinsiyet { get; set; }

        public DateTime OgrenciDogumTarihi { get; set; }

        [StringLength(11)]
        public string OgrenciTelefon { get; set; }

        [StringLength(50)]
        public string OgrenciMail { get; set; }

        [StringLength(20)]
        public string OgrenciSifre { get; set; }

        public bool OgrenciDurum { get; set; }
        public byte[] OgrenciResim { get; set; }

        List<Proje> Projeler { get; set; }
    }
}
