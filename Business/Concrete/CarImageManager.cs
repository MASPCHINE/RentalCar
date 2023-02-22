using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImage, IFileHelper fileHelper)
        {
            _carImageDal = carImage;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, CarImage entity)
        {
            IResult result = BusinessRules.Run(CheckCarImagesCount(entity.CarId));
            if (result != null)
            {
                return result;
            }
            entity.ImagePath = _fileHelper.Upload(file, ImagePath.Root);
            entity.Date = DateTime.Now;
            _carImageDal.Add(entity);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(CarImage entity)
        {
            _fileHelper.Delete(ImagePath.Root + entity.ImagePath);
            _carImageDal.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId), Messages.GetCarImage);
        }

       

        public IDataResult<List<CarImagesDto>> GetImagesByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImagesDto>>(_carImageDal.GetImagesByCarId(carId));
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.CarImageId == id), Messages.GetCarImage);
        }

        public IResult Update(IFormFile file, CarImage entity)
        {
            var filePath = ImagePath.Root + entity.ImagePath;
            entity.ImagePath = _fileHelper.Update(file, filePath, ImagePath.Root);
            _carImageDal.Update(entity);
            return new SuccessResult(Messages.Updated);
        }
        private IResult CheckCarImagesCount(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult(Messages.CarImageCountOfImagesLimit);
            }
            return new SuccessResult();

        }
    }
}
