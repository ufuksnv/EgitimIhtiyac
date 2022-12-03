using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string? AboutMail { get; set; }
        public string? AboutNumber { get; set; }
        public string? FacebookAdress { get; set; }
        public string? TwitterAdress { get; set; }
        public string? InstagramAdress { get; set; }
    }
}
