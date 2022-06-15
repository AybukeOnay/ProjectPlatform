using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjeBelirlemePlatformu.Controllers
{
    public class LoginController : Controller
    {
        KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Kullanici cls_kullanici)
        {
            Context context = new Context();
            var dataValue = context.Kullanicilar.FirstOrDefault(x => x.Mail == cls_kullanici.Mail && x.Sifre == cls_kullanici.Sifre);

            if (dataValue != null  && dataValue.Tur==1)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,cls_kullanici.Mail)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "AdminCalismaAlani");
            }
            else if (dataValue != null && dataValue.Tur == 2)

            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,cls_kullanici.Mail)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("OgrenciProfilListele", "Ogrenci");
            }
            else if (dataValue != null && dataValue.Tur == 3)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,cls_kullanici.Mail)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("OgretimElemaniProfil", "OgretimElemani");
            }

            else
            {
                return View();
            }

        }
    }
}
