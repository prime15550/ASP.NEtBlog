using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Business.Abstract;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class RegisterController : Controller
    {
       
        ItblkullaniciService _ItblkullaniciService;
        ItblyazarService _ItblyazarService;

        public RegisterController(ItblkullaniciService ItblkullaniciService, ItblyazarService ItblyazarService)
        {
            _ItblkullaniciService = ItblkullaniciService;
            _ItblyazarService = ItblyazarService;
        }

        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Index(ModelUser user )
        {
            
            bool isitexists = false; 
            List<Tblkullanici> list = _ItblkullaniciService.GetAll().ToList();
            List<Tblyazar> list1 = _ItblyazarService.GetAll().ToList();
            if ( user.isyazar==1)
            {
                foreach (var VARIABLE in list1)
                {
                    if (VARIABLE.Mail == user.email)
                    {
                        isitexists = true;
                    }
                }
            }
            else
            {
                foreach (var VARIABLE in list)
                {
                    if (VARIABLE.Mail == user.email)
                    {
                        isitexists = true;
                    }
                }

            }

            if (!isitexists)
            {
                if (!(user.isyazar==1))
                {
                    _ItblkullaniciService.Add(new Tblkullanici()
                    {
                        Id = list.Count + 1,
                        Isim = user.isim,
                        Soyisim = user.soyisim,
                        Mail = user.email,
                        Password = user.sifre,
                        Username = user.username
                    });
                    return Redirect("~/Home/index");
                }
                else
                {
                   
                        _ItblyazarService.Add(new Tblyazar()
                        {
                            Id = list1.Count + 1,
                            Isim = user.isim,
                            Soyisim = user.soyisim,
                            Mail = user.email,
                            Password = user.sifre,
                            Aciklama = user.username
                           

                        });
                      return Redirect("~/Home/index");
                    
                }

            }
            else
            {
                user.isitexits = true;

                return View(user);
            }
            
        }
    }
}
