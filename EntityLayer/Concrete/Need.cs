using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Need
    {
        [Key]
        public int NeedId { get; set; }
        public string? NeedName { get; set; }
        public string? NeedNumber { get; set; }
        public string? NeedAdress { get; set; }
        public string? NeedDetail { get; set; }      
        public bool Status { get; set; }


        public int MemberId { get; set; }
        public Member Member { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
