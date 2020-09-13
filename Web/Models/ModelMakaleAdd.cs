using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Blog.Models
{
    public class ModelMakaleAdd
    {
        [Required]
        public string email { get; set; }
        [Required]
        public string sifre { get; set; } 
        [Required]
        public string baslik { get; set; }
        [Required]
        public int kategoriID { get; set; }
        [Required]
        public string icerik { get; set; }
        public IFormFile resimurl { get; set; }

        

    }
}
