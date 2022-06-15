using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBelirlemePlatformu.View_Component.Mesajlar
{
    public class OgretimElemaniMesajBildirimleri : ViewComponent
    {
        MesajManager bm = new MesajManager(new EfMesajRepository());

        public IViewComponentResult Invoke()
        {
            string p;
            p = "onerbarut@gazi.edu.tr";
            var degerler = bm.OgretimElemaninaGelenMesajlariListele(p);
            return View(degerler);
        }

    }
}
