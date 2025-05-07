using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBusService
    {
        List<Bus> BusList();
        void BusInsert(Bus t);
        void BusUpdate(Bus t);
        void BusDelete(Bus t);
        Bus GetById(int id);
    }
}
