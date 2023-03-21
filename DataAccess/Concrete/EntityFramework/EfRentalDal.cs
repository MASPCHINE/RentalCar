using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public Rental GetCarAvailable(Expression<Func<Rental, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Rental>().OrderByDescending(r => r.RentalId).FirstOrDefault(filter);
            }
        }

        public List<RentalDetailsDto> GetRentalDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join d in context.Cars
                             on r.CarId equals d.CarId
                             join b in context.Brands
                             on d.CarId equals b.BrandId
                             join a in context.Colors
                             on d.ColorId equals a.ColorId
                             select new RentalDetailsDto {RentalId=r.RentalId,BrandName=b.Name,RentDate=r.RentDate,ReturnDate=r.ReturnDate};
                return result.ToList();
            }
        }
    }
}
