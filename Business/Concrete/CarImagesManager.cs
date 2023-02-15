using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImagesManager : ICarImageService
    {
        ICarImageDal _carImage;
        public CarImagesManager(ICarImageDal carImage)
        {
            _carImage = carImage;
        }

        public IResult Add(CarImage entity)
        {
            _carImage.Add(entity);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(CarImage entity)
        {
            _carImage.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImage.Get(c => c.CarImagesId == id), Messages.GetCarImage);
        }

        public IResult Update(CarImage entity)
        {
            _carImage.Update(entity);
            return new SuccessResult(Messages.Updated);
        }
    }
}
