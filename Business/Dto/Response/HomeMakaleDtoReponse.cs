using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Dto.Model;
using Entity.Entities;

namespace Business.Dto.Response
{
   public class HomeMakaleDtoReponse
   {
        ItblMakaleService _ItblMakaleService;
         ItblyazarService _ItblyazarService;
         ItblKategoriService _ItbKategoriService; 
         ItblyorumService _ItblyorumService;
          ItbletiketService _ItbletiketService;
          ItblmakaleetiketService _ItblmakaleetiketService;
           ItblresimService _ItblresimService;

         public HomeMakaleDtoReponse(
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

         public List<HomeMakaleDto> MakaleList()
         {
            List<HomeMakaleDto> list = new List<HomeMakaleDto>();
            HomeMakaleDto makale;
            List < TblMakale > makalelist = _ItblMakaleService.GetAll().ToList();
            foreach (var VARIABLE in makalelist)
            {
                makale = new HomeMakaleDto();
                makale.id = VARIABLE.Id;
                makale.baslik = VARIABLE.Baslik;
                makale.etiket = _ItbletiketService.GetById(_ItblmakaleetiketService.getbyid(VARIABLE.Id).FirstOrDefault().EtiketId).Adi;
                makale.UploDateTime = VARIABLE.Yuklemetarihi;
                makale.aciklama = VARIABLE.Aciklama;
                makale.yazar = _ItblyazarService.GetById(VARIABLE.YazarId).Isim + " " +
                               _ItblyazarService.GetById(VARIABLE.YazarId).Soyisim;
                makale.yazaraciklama = _ItblyazarService.GetById(VARIABLE.YazarId).Aciklama;
                List<Tblyorum> yorumlar = _ItblyorumService.GetAll();
                int count = 0;
                foreach (var s in yorumlar)
                {
                    if (s.MakaleId==VARIABLE.Id)
                    {
                        count++;
                    }
                }

                makale.yorumSayisi = count;
                makale.resimUrl = _ItblresimService.GetById(VARIABLE.Id).ResimUrl;
                makale.kategori = _ItbKategoriService.GetById(VARIABLE.KategoriId).Adi;
                list.Add(makale);
            }

            return list;
         }

         public List<HomeMakaleDto> geziList()
         {
             List<HomeMakaleDto> list = new List<HomeMakaleDto>();
             HomeMakaleDto makale;
             List<TblMakale> makalelist = _ItblMakaleService.GetAll().ToList();
             foreach (var VARIABLE in makalelist)
             {
                 makale = new HomeMakaleDto();
                 makale.baslik = VARIABLE.Baslik;
                 makale.etiket = _ItbletiketService.GetById(_ItblmakaleetiketService.getbyid(VARIABLE.Id).FirstOrDefault().EtiketId).Adi;
                 makale.UploDateTime = VARIABLE.Yuklemetarihi;
                 makale.aciklama = VARIABLE.Aciklama;
                 makale.yazar = _ItblyazarService.GetById(VARIABLE.YazarId).Isim + " " +
                                _ItblyazarService.GetById(VARIABLE.YazarId).Soyisim;
                 makale.yazaraciklama = _ItblyazarService.GetById(VARIABLE.YazarId).Aciklama;
                 List<Tblyorum> yorumlar = _ItblyorumService.GetAll();
                 int count = 0;
                 foreach (var s in yorumlar)
                 {
                     if (s.MakaleId == VARIABLE.Id)
                     {
                         count++;
                     }
                 }

                 makale.yorumSayisi = count;
                 makale.resimUrl = _ItblresimService.GetById(VARIABLE.Id).ResimUrl;
                 makale.kategori = _ItbKategoriService.GetById(VARIABLE.KategoriId).Adi;
                 if (VARIABLE.KategoriId==1)
                 {
                     list.Add(makale);
                 }
            }


             return list;
        }
         public List<HomeMakaleDto> magazinList()
         {
             List<HomeMakaleDto> list = new List<HomeMakaleDto>();
             HomeMakaleDto makale;
             List<TblMakale> makalelist = _ItblMakaleService.GetAll().ToList();
             foreach (var VARIABLE in makalelist)
             {
                 makale = new HomeMakaleDto();
                 makale.baslik = VARIABLE.Baslik;
                 makale.etiket = _ItbletiketService.GetById(_ItblmakaleetiketService.getbyid(VARIABLE.Id).FirstOrDefault().EtiketId).Adi;
                 makale.UploDateTime = VARIABLE.Yuklemetarihi;
                 makale.aciklama = VARIABLE.Aciklama;
                 makale.yazar = _ItblyazarService.GetById(VARIABLE.YazarId).Isim + " " +
                                _ItblyazarService.GetById(VARIABLE.YazarId).Soyisim;
                 makale.yazaraciklama = _ItblyazarService.GetById(VARIABLE.YazarId).Aciklama;
                 List<Tblyorum> yorumlar = _ItblyorumService.GetAll();
                 int count = 0;
                 foreach (var s in yorumlar)
                 {
                     if (s.MakaleId == VARIABLE.Id)
                     {
                         count++;
                     }
                 }

                 makale.yorumSayisi = count;
                 makale.resimUrl = _ItblresimService.GetById(VARIABLE.Id).ResimUrl;
                 makale.kategori = _ItbKategoriService.GetById(VARIABLE.KategoriId).Adi;
                 if (VARIABLE.KategoriId == 2)
                 {
                     list.Add(makale);
                 }
             }


             return list;
         }
    }
}
