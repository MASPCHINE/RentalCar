using Business.Abstract;
using Business.Constants;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
        ICarImageDal _carImage;
        IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImage, IFileHelper fileHelper)
        {
            _carImage = carImage;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file , CarImage entity)
        {
            entity.ImagePath = _fileHelper.Upload(file,ImagePath.Root);
            entity.Date = DateTime.Now;
            _carImage.Add(entity);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(CarImage entity)
        {
            _fileHelper.Delete(ImagePath.Root + entity.ImagePath);
            _carImage.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImage.Get(c => c.CarImageId == id), Messages.GetCarImage);
        }

        public IResult Update(IFormFile file,CarImage entity)
        {
            var filePath = ImagePath.Root + entity.ImagePath;
            entity.ImagePath = _fileHelper.Update(file, filePath, ImagePath.Root);
            _carImage.Update(entity);
            return new SuccessResult(Messages.Updated);
        }
    }
}
