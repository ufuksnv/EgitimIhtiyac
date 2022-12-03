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
    public class NeedManager : INeedService
    {
        INeedDal _needDal;

        public NeedManager(INeedDal needDal)
        {
            _needDal = needDal;
        }

        public void TAdd(Need t)
        {
            _needDal.Insert(t);
        }

        public void TDelete(Need t)
        {
            _needDal.Delete(t);
        }

        public Need TGetByID(int id)
        {
          return  _needDal.GetByID(id);
        }

        public List<Need> TGetList()
        {
          return  _needDal.GetList();
        }

        public void TUpdate(Need t)
        {
            _needDal.Update(t);
        }

        public List<Need> GetNeedListByMember(int id)
        {
            
             return _needDal.GetAll(x => x.MemberId == id);
        }
    }
}
