using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from cars in context.Cars
                             join brands in context.Brands
                             on cars.BrandId equals brands.Id
                             join colors in context.Colors
                             on cars.ColorId equals colors.Id
                             select new CarDetailDto
                             {
                                 Id = cars.Id,
                                 BrandName = brands.Name,
                                 ColorName = colors.Name,
                                 DailyPrice = cars.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
