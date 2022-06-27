using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBelirlemePlatformu.Controllers
{
    public class AdminMesajController : Controller
    {
        MesajManager mesajManager = new MesajManager(new EfMesajRepository());

        public IActionResult AdminMesaj()
        {
            var mesajDeger = mesajManager.TListeleBL();
            return View(mesajDeger);
        }

      
    }
}
