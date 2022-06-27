using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBelirlemePlatformu.Controllers
{
    public class DosyaController : Controller
    {
        ProjeManager projeManager = new ProjeManager(new EfProjeRepository());
        DosyaManager dosyaManager = new DosyaManager(new EfDosyaRepository());
        Context context = new Context();

        public IActionResult DosyaListele()
        {
            var values = dosyaManager.TListeleBL();

            return View(values);
        }

        public IActionResult DosyaSil(int id)
        {
            var values = dosyaManager.TIDIleGetirBL(id);
            dosyaManager.TSilBL(values);
            return RedirectToAction("DosyaListele");

        }

        //public IActionResult DosyaOku(IFormFile files)
        //{
        //    Byte[] bytes = null;

        //    if (files.FileName != null)

        //    {

        //        Stream fs = files..InputStream;

        //        BinaryReader br = new BinaryReader(fs);

        //        bytes = br.ReadBytes((Int32)fs.Length);
        //        return View();
        //}


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormFile files)
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
                        DosyaAd = fileName,
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
            return View();
        }

    }
}

