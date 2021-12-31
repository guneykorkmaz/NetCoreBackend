using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from rentals in context.Rentals
                             join cars in context.Cars
                             on rentals.CarId equals cars.Id
                             join brands in context.Brands
                             on cars.BrandId equals brands.Id
                             join customers in context.Customers
                             on rentals.CustomerId equals customers.Id
                             join users in context.Users
                             on customers.UserId equals users.Id
                             select new RentalDetailDto
                             {
                                 Id = rentals.Id,
                                 BrandName = brands.Name,
                                 FullName = users.FirstName + " " + users.LastName,
                                 RentDate = rentals.RentDate,
                                 ReturnDate = rentals.ReturnDate
                             };
                return result.ToList();
                             
            }
        }
    }
}
