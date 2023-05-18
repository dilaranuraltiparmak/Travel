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
    public class AboutManager : IAboutService
    {
        //IAboutDal'ın amacı entitylere ulasmak
        //IAboutDal ile constractor metodun amacı depencyınjection saglamaktır
        //IAboutDal2'ın kalıtım aldıgı IGenericDaldaki metodları kullanabilmeyi amaclarız
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void TAdd(About t)
        {
          _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
;        }

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
           return _aboutDal.GetList();
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
