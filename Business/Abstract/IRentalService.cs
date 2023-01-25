using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental entity);
        IResult Delete(Rental entity);
        IResult Update(Rental entity);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetCarAvailable(int carId);

    }
}
