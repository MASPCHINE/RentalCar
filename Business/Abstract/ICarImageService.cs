using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImage entity);
        IResult Delete(CarImage entity);
        IResult Update(CarImage entity);
        IDataResult<CarImage> GetById(int id);
    }
}
