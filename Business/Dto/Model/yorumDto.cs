using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Dto.Model
{
    public class yorumDto
    {
        public int Id { get; set; }
        public string Yorum { get; set; }
        public DateTime? Date { get; set; }
        public string User { get; set; }
        public int MakaleId { get; set; }

        
    }
}
