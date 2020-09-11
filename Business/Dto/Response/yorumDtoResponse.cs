using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Dto.Model;
using Entity.Entities;

namespace Business.Dto.Response
{
    public class yorumDtoResponse
    {
        ItblyorumService _ItblyorumService;
        ItblkullaniciService _ItblkullaniciService;

        public yorumDtoResponse(ItblyorumService ItblyorumService,
            ItblkullaniciService ItblkullaniciService)
        {
            _ItblkullaniciService = ItblkullaniciService;
            _ItblyorumService = ItblyorumService;
           
        }

        public List<yorumDto> yorumlist()
        {
            List<yorumDto> list =new List<yorumDto>();
            yorumDto yorum;
            List<Tblyorum> yorumlist = _ItblyorumService.GetAll().ToList();
            foreach (var i in yorumlist)
            {
                yorum = new yorumDto();
                yorum.Date = i.Date;
                yorum.MakaleId = i.MakaleId;
                yorum.Yorum = i.Yorum;
                yorum.Id = i.Id;
                yorum.User = _ItblkullaniciService.GetById(i.UserId).Isim + " " +
                             _ItblkullaniciService.GetById(i.UserId).Soyisim;
                list.Add(yorum);
            }

            return list;
        }
    }
}
