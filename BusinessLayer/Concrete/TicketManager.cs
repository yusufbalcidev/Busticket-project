using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TicketManager : ITicketService
    {
        ITicketDal _ticketDal;

        public TicketManager(ITicketDal TicketDal)
        {
            _ticketDal = TicketDal;
        }

        public void TicketDelete(Ticket c)
        {
            _ticketDal.Delete(c);
        }

        public void TicketInsert(Ticket c)
        {
            _ticketDal.Insert(c);
        }

        public List<Ticket> TicketList()
        {
            return _ticketDal.liste();
        }

        public void TicketUpdate(Ticket c)
        {
            _ticketDal.Update(c);
        }

        public Ticket GetById(int id)
        {
            return _ticketDal.Get(x => x.Id == id);
        }
      
    }
}
