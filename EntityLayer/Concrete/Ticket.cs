using EntityLayer.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ticket : Base
    {
        public string From { get; set; }
        public string To { get; set; }
        public string DateTime { get; set; }
        public string Time { get; set; }
        public string Seat { get; set; }

    }
}
