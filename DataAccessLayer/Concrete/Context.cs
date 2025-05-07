using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        DbSet<Ticket> Ticket { get; set; }
        DbSet<Bus> Bus { get; set; }
    }
}
