using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test1109.Models
{
    public class MemberInfoViewModel
    {
        public Member Member { get; set; }
        public List<Product> Products { get; set; }
    }
}