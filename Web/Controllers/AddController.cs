using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Blog.Models;
using Business.Abstract;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class AddController : Controller
    {
        ItblMakaleService _ItblMakaleService;
        ItblmakaleetiketService _ItblmakaleetiketService;
        ItblyazarService _ItblyazarService;

        public AddController(ItblMakaleService ItblMakaleService,
            ItblmakaleetiketService ItblmakaleetiketService, ItblyazarService ItblyazarService)
        {
            _ItblmakaleetiketService = ItblmakaleetiketService;
            _ItblMakaleService = ItblMakaleService;
            _ItblyazarService = ItblyazarService;
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

            return Redirect("~/Home/index");
        }
    }
}
