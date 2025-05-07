using EntityLayer.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Bus : Base
    {
        public string Title { get; set; }
        public string Limit { get; set; }
        public string Rate { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
       
    }
}
