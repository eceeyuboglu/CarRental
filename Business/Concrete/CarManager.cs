using Business.Abstarct;
using DataAccess.Abstarct;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            var result= _carDal.GetAll(c => c.BrandId == brandId);
            return result;
        }

        public Car GetByCarId(int carId)
        {
            var result= _carDal.Get(c => c.CarId == carId);
            return result;
        }

        public List<Car> GetByColorId(int colorId)
        {
            var result = _carDal.GetAll(c => c.ColorId == colorId);
            return result;
        }
    }
}
