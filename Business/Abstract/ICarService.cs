﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int id);
        List<Car> GetAllByColorId(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        Car GetById(int id);
        //List<CarDetailDto> GetProductDetails();
    }
}
