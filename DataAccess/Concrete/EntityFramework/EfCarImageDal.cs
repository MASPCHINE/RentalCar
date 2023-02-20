using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, ReCapContext>, ICarImageDal
    {
        public List<CarImagesDto> GetImagesByCarId(int carId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.CarImages
                             where c.CarId == carId
                             select new CarImagesDto { ImagePath = c.ImagePath };
                return result.ToList();
            }
        }
    }
}
