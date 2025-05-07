using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BusManager : IBusService
    {
        IBusDal _busDal;

        public BusManager(IBusDal BusDal)
        {
            _busDal = BusDal;
        }

        public void BusDelete(Bus b)
        {
            _busDal.Delete(b);
        }

        public void BusInsert(Bus b)
        {
            _busDal.Insert(b);
        }

        public List<Bus> BusList()
        {
            return _busDal.liste();
        }

        public void BusUpdate(Bus b)
        {
            _busDal.Update(b);
        }

        public Bus GetById(int id)
        {
            return _busDal.Get(x => x.Id == id);
        }

    }
}
