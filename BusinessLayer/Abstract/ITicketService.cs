using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITicketService
    {
        List<Ticket> TicketList();
        void TicketInsert(Ticket t);
        void TicketUpdate(Ticket t);
        void TicketDelete(Ticket t);
        Ticket GetById(int id);
    }
}
