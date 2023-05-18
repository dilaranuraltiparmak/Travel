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
    public class SubAboutManager : ISubAboutSevice
    {
        ISubAboutDal _subAbotDal;
        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAbotDal = subAboutDal;
        }
        public void TAdd(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public SubAbout TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
           return _subAbotDal.GetList();
        }

        public void TUpdate(SubAbout t)
        {
            throw new NotImplementedException();
        }
    }
}
