using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Business.Abstract;
using Business.Dto.Model;
using Business.Dto.Response;
using Entity.Entities;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class SingleController : Controller
    {
        ModelMakaleIndex _modelMakaleIndex;
        ModelMakale homeMakaleDto;
        ItblMakaleService _ItblMakaleService;
        ItblyazarService _ItblyazarService;
        ItblKategoriService _ItbKategoriService;
        ItblyorumService _ItblyorumService;
        ItbletiketService _ItbletiketService;
        ItblmakaleetiketService _ItblmakaleetiketService;
        ItblresimService _ItblresimService;
        ItblkullaniciService _ItblkullaniciService;
        public SingleController(
            ItblMakaleService ItblMakaleService,
            ItblyazarService ItblyazarService,
            ItblKategoriService ItbKategoriService,
            ItblyorumService ItblyorumService, ItbletiketService ItbletiketService, ItblmakaleetiketService ItblmakaleetiketService, ItblresimService tblresimService, ItblkullaniciService ItblkullaniciService)
        {
            _ItblMakaleService = ItblMakaleService;
            _ItbKategoriService = ItbKategoriService;
            _ItblyazarService = ItblyazarService;
            _ItblyorumService = ItblyorumService;
            _ItbletiketService = ItbletiketService;
            _ItblmakaleetiketService = ItblmakaleetiketService;
            _ItblresimService = tblresimService;
            _ItblkullaniciService = ItblkullaniciService;
        }

        public IActionResult Index()
        {
            HomeMakaleDtoReponse db = new HomeMakaleDtoReponse(_ItblMakaleService, _ItblyazarService, _ItbKategoriService, _ItblyorumService, _ItbletiketService, _ItblmakaleetiketService, _ItblresimService);
            yorumDtoResponse db1 = new yorumDtoResponse(_ItblyorumService,_ItblkullaniciService);
            _modelMakaleIndex = new ModelMakaleIndex();
            _modelMakaleIndex.liste = db.MakaleList();
            homeMakaleDto = new ModelMakale();
            string Url = Request.GetDisplayUrl();
            string[] sub = Url.Split("/");
            int length = sub.Length;
            int id = Int32.Parse(sub[length - 1].Substring(0,1));
            foreach (var VARIABLE in _modelMakaleIndex.liste)
            {
                if (id==VARIABLE.id)
                {
                    homeMakaleDto.makale = VARIABLE;
                }
            }

            homeMakaleDto.yorumlar = new List<yorumDto>();
            foreach (var VARIABLE in db1.yorumlist())
            {
                if (id == VARIABLE.MakaleId)
                {
                    homeMakaleDto.yorumlar.Add(VARIABLE);
                }
                
            }
            

                return View(homeMakaleDto);
        }

        [HttpPost]
        public IActionResult Index(ModelMakale makale)
        {
            int id = _ItblkullaniciService.iskullaniciExists(makale.YorumSubmit.email, makale.YorumSubmit.password);
            string Url = Request.GetDisplayUrl();
            string[] sub = Url.Split("/");
            int length = sub.Length;
            int id1 = Int32.Parse(sub[length - 1].Substring(0, 1));
            if (id != -999)
            {
                _ItblyorumService.Add(new Tblyorum()
                {
                    Id = _ItblyorumService.GetAll().Count + 1,
                    Date = DateTime.Now,
                    MakaleId = id1 ,
                    UserId = id,
                    Yorum = makale.YorumSubmit.message

                });

            }
            HomeMakaleDtoReponse db = new HomeMakaleDtoReponse(_ItblMakaleService, _ItblyazarService, _ItbKategoriService, _ItblyorumService, _ItbletiketService, _ItblmakaleetiketService, _ItblresimService);
            yorumDtoResponse db1 = new yorumDtoResponse(_ItblyorumService, _ItblkullaniciService);
            _modelMakaleIndex = new ModelMakaleIndex();
            _modelMakaleIndex.liste = db.MakaleList();
            homeMakaleDto = new ModelMakale();
            
           
            
            foreach (var VARIABLE in _modelMakaleIndex.liste)
            {
                if (id1 == VARIABLE.id)
                {
                    homeMakaleDto.makale = VARIABLE;
                }
            }

            homeMakaleDto.yorumlar = new List<yorumDto>();
            foreach (var VARIABLE in db1.yorumlist())
            {
                if (id1  == VARIABLE.MakaleId)
                {
                    homeMakaleDto.yorumlar.Add(VARIABLE);
                }
            }

            return View(homeMakaleDto);
            
        }

    }
}
