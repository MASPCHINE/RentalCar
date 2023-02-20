using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file ,CarImage entity);
        IResult Delete(CarImage entity);
        IResult Update(IFormFile file ,CarImage entity);
        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetByCarId(int carId);
        IDataResult<List<CarImagesDto>> GetImagesByCarId(int carId);
    }
}
