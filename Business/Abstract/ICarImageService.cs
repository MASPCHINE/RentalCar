using Core.Utilities.Results;
using Entities.Concrete;
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
    }
}
