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
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public CarDetailDto GetCar(Expression<Func<CarDetailDto, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join a in context.Colors
                             on c.ColorId equals a.ColorId
                             select new CarDetailDto { CarId = c.CarId, CarName = c.CarName, BrandName = b.Name, ColorName = a.Name, ModelYear = c.ModelYear, Description = c.Description, DailyPrice = c.DailyPrice };
                return result.FirstOrDefault();
            }
        }

        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join a in context.Colors
                             on c.ColorId equals a.ColorId
                             select new CarDetailDto { CarId = c.CarId, CarName = c.CarName, BrandName = b.Name, ColorName = a.Name,ModelYear=c.ModelYear,Description=c.Description,DailyPrice=c.DailyPrice };
                return result.ToList();
            }
        }
    }
}
