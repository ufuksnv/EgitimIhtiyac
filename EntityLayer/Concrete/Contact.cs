using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string? ContactName { get; set; }
        public string? ContactEmail { get; set; }
        public int? ContactPhone { get; set; }
        public string? ContactMessage { get; set; }
        public bool ContactStatus { get; set; }
    }
}
