using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails(Func<Car,bool> filter = null);
        List<Car> GetCarsByBrandId(Func<Car,bool> filter = null);
        List<Car> GetCarsByColorId(Func<Car,bool> filter = null);
    }
}
