using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBelirlemePlatformu.View_Component.Bildirimler
{
    public class BildirimListesi:ViewComponent
    {
        BildirimManager bm = new BildirimManager(new EfBildirimRepository());
        public IViewComponentResult Invoke()
        {
            var degerler = bm.TListeleBL();
            return View(degerler);
        }
    }
}
