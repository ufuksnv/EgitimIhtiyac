using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        public string? MemberName { get; set; }
        public string? MemberEmail { get; set; }
        public string? Password { get; set; }
        public string? SchoolName { get; set; }
        public string? Adress { get; set; }
        public int PhoneNumber { get; set; }
        public bool MemberStatus { get; set; }


        public List<Need> Needs { get; set; }

    }
}
