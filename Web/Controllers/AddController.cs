using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Blog.Models;
using Business.Abstract;
using Entity.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class AddController : Controller
    {
        ItblMakaleService _ItblMakaleService;
        ItblmakaleetiketService _ItblmakaleetiketService;
        ItblyazarService _ItblyazarService;
        ItblresimService _ItblresimService;
        private readonly IHostingEnvironment _hostingEnvironment;

        public AddController(ItblMakaleService ItblMakaleService,
            ItblmakaleetiketService ItblmakaleetiketService, ItblyazarService ItblyazarService, IHostingEnvironment hostingEnvironment, ItblresimService ItblresimService)
        {
            _ItblmakaleetiketService = ItblmakaleetiketService;
            _ItblMakaleService = ItblMakaleService;
            _hostingEnvironment = hostingEnvironment;
            _ItblyazarService = ItblyazarService;
            _ItblresimService = ItblresimService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ModelMakaleAdd makale)
        {
            List<TblMakale> list = _ItblMakaleService.GetAll().ToList();
            int yazarid = _ItblyazarService.yazarid(makale.email, makale.sifre);
            _ItblMakaleService.Add(new TblMakale()
            {
                Id = list.Count + 1,
                Baslik = makale.baslik,
                KategoriId = makale.kategoriID,
                YazarId = yazarid,
                Yuklemetarihi = DateTime.Now,
                Aciklama = makale.icerik
            });
            _ItblmakaleetiketService.Add(new Tblmakaleetiket()
            {
                EtiketId = makale.kategoriID,
                MakaleId = list.Count + 1
            });
            var fileName = _hostingEnvironment.WebRootPath + @"\images\resimler\";
            makale.resimurl.CopyTo(new FileStream(fileName + (list.Count + 1) + ".jpg", FileMode.Create));
            string ResimUrl = "images/resimler/" + (list.Count + 1) + ".jpg";
            _ItblresimService.Add(new Tblresim()
            {
                ResimUrl = ResimUrl,
                MakaleId = list.Count + 1,
                Id = _ItblresimService.GetAll().Count + 1
            });

            return Redirect("~/Home/index");
        }
    }
}
