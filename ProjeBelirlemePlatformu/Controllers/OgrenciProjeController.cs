using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBelirlemePlatformu.Controllers
{
    public class OgrenciProjeController : Controller
    {
        ProjeManager projeManager = new ProjeManager(new EfProjeRepository());
        Context context = new Context();

        public IActionResult OgrenciProjeListele()
        {
            
            var ogrenciMail = User.Identity.Name;
            var ogrenciId = context.Ogrenciler.Where(x => x.OgrenciMail == ogrenciMail).Select(y => y.OgrenciID).FirstOrDefault();
            var ogrenciProje = projeManager.ProjeLookUpGetirOgrenciBL(ogrenciId);
            
            return View(ogrenciProje);
        }

        [HttpGet]
        public IActionResult OgrenciProjeEkle()
        {
            List<SelectListItem> calismaAlanlari = (from x in context.CalismaAlanlari.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.CalismaAlaniTanim,
                                                 Value = x.CalismaAlaniID.ToString()
                                             }).ToList();

            ViewBag.v1 = calismaAlanlari;

            List<SelectListItem> ogretimElemanlari = (from x in context.OgretimElemanlari.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.OgretimElemaniAd + " " + x.OgretimElemaniSoyad,
                                                 Value = x.OgretimElemaniID.ToString()
                                             }).ToList();

            ViewBag.v2 = ogretimElemanlari;
            return View();
        }

        [HttpPost]
        public IActionResult OgrenciProjeEkle(Proje cls_proje)
        {
            var ogrenciMail = User.Identity.Name;
            var ogrenciId = context.Ogrenciler.Where(x => x.OgrenciMail == ogrenciMail).Select(y => y.OgrenciID).FirstOrDefault();
            cls_proje.OgrenciID = ogrenciId;
            cls_proje.ProjeTarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            projeManager.TEkleBL(cls_proje);
            return RedirectToAction("OgrenciProjeListele");
        }

        [HttpGet]
        public IActionResult OgrenciProjeGuncelle(int vrb_id)
        {
            var ogrenciMail = User.Identity.Name;
            var ogrenciId = context.Ogrenciler.Where(x => x.OgrenciMail == ogrenciMail).Select(y => y.OgrenciID).FirstOrDefault();
            vrb_id = ogrenciId;
            var deger = projeManager.TIDIleGetirBL(vrb_id);  
            
            List<SelectListItem> calismaAlanlari = (from x in context.CalismaAlanlari.ToList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.CalismaAlaniTanim,
                                                        Value = x.CalismaAlaniID.ToString()
                                                    }).ToList();

            ViewBag.v1 = calismaAlanlari;

            List<SelectListItem> ogretimElemanlari = (from x in context.OgretimElemanlari.ToList()
                                                      select new SelectListItem
                                                      {
                                                          Text = x.OgretimElemaniAd + " " + x.OgretimElemaniSoyad,
                                                          Value = x.OgretimElemaniID.ToString()
                                                      }).ToList();

            ViewBag.v2 = ogretimElemanlari;
            return View(deger);
        }

        [HttpPost]
        public IActionResult OgrenciProjeGuncelle(Proje cls_proje)
        {
            var ogrenciMail = User.Identity.Name;
            var ogrenciId = context.Ogrenciler.Where(x => x.OgrenciMail == ogrenciMail).Select(y => y.OgrenciID).FirstOrDefault();
            cls_proje.OgrenciID = ogrenciId;
            cls_proje.ProjeTarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            projeManager.TGuncelleBL(cls_proje);
            return RedirectToAction("OgrenciProjeListele");
        }

        public IActionResult OgrenciProjeSil(int id)
        {
            var projeDeger = projeManager.TIDIleGetirBL(id);
            projeManager.TSilBL(projeDeger);
            return RedirectToAction("OgrenciProjeListele");
        }

        [HttpGet]
        public IActionResult ProjeDosyaEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProjeDosyaEkle(IFormFile files)
        {
            if (files != null)
            {
                if (files.Length > 0)
                {
                    //Getting FileName
                    var fileName = Path.GetFileName(files.FileName);
                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);
                    // concatenating  FileName + FileExtension
                    var newFileName = String.Concat(Convert.ToString(Guid.NewGuid()), fileExtension);

                    var objfiles = new Dosya()
                    {
                        DosyaID = 0,
                        DosyaAd = newFileName,
                        DosyaTur = fileExtension,
                        ProjeID = 1


                    };

                    using (var target = new MemoryStream())
                    {
                        files.CopyTo(target);
                        objfiles.DosyaVeri = target.ToArray();
                    }

                    context.Dosyalar.Add(objfiles);
                    context.SaveChanges();

                }
            }
            return RedirectToAction("OgrenciProjeListele");
        }
    }
}
