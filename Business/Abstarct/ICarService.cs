using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetByCarId(int carId);
        List<Car> GetByBrandId(int brandId);
        List<Car> GetByColorId(int colorId);

    }
}
