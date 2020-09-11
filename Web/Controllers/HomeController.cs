using System.Collections.Generic;
using System.Linq;
using Blog.Models;
using Business.Abstract;
using Business.Dto.Model;
using Business.Dto.Response;
using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers
{
   public class HomeController : Controller
   {
        ModelMakaleIndex _modelMakaleIndex;
      ItblMakaleService       _ItblMakaleService;
      ItblyazarService        _ItblyazarService;
      ItblKategoriService     _ItbKategoriService;
      ItblyorumService        _ItblyorumService;
      ItbletiketService       _ItbletiketService;
      ItblmakaleetiketService _ItblmakaleetiketService;
      ItblresimService        _ItblresimService;
      public HomeController(
          ItblMakaleService ItblMakaleService,
          ItblyazarService ItblyazarService,
          ItblKategoriService ItbKategoriService,
          ItblyorumService ItblyorumService, ItbletiketService ItbletiketService, ItblmakaleetiketService ItblmakaleetiketService, ItblresimService tblresimService)
      {
          _ItblMakaleService = ItblMakaleService;
          _ItbKategoriService = ItbKategoriService;
          _ItblyazarService = ItblyazarService;
          _ItblyorumService = ItblyorumService;
          _ItbletiketService = ItbletiketService;
          _ItblmakaleetiketService = ItblmakaleetiketService;
          _ItblresimService = tblresimService;
      }

        public IActionResult Index()
      {
          HomeMakaleDtoReponse db = new HomeMakaleDtoReponse(_ItblMakaleService, _ItblyazarService, _ItbKategoriService, _ItblyorumService, _ItbletiketService, _ItblmakaleetiketService, _ItblresimService);
          _modelMakaleIndex = new ModelMakaleIndex();

          _modelMakaleIndex.liste = db.MakaleList();
          return View(_modelMakaleIndex);
      }
  }
}
