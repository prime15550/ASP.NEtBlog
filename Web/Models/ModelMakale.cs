using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Dto.Model;

namespace Blog.Models
{
    public class ModelMakale
    {
        public HomeMakaleDto makale { get; set; }
        public List<yorumDto> yorumlar { get; set; }
        public modelYorumSubmit YorumSubmit { get; set; }
    }
}
