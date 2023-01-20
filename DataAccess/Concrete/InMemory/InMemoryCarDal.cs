using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> 
            {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2016,DailyPrice=100000,Description="İyi Durumda"}, 
                new Car{CarId=2,BrandId=1,ColorId=2,ModelYear=2017,DailyPrice=103000,Description="İyi Durumda"},
                new Car{CarId=3,BrandId=2,ColorId=1,ModelYear=2018,DailyPrice=110000,Description="İyi Durumda"},
                new Car{CarId=4,BrandId=2,ColorId=3,ModelYear=2019,DailyPrice=150000,Description="İyi Durumda"},
                new Car{CarId=5,BrandId=3,ColorId=2,ModelYear=2020,DailyPrice=190000,Description="İyi Durumda"},
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDeleted = _car.FirstOrDefault(c => c.CarId == car.CarId);  
            _car.Remove(carToDeleted);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return (List<Car>)_car.Where(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return (List<Car>)_car.Where(c => c.ColorId == colorId);
        }

    
        public void Update(Car car)
        {
            Car carToUpdated = _car.FirstOrDefault(c=> c.CarId==car.CarId);
            carToUpdated.BrandId =car.BrandId;
            carToUpdated.ColorId =car.ColorId;
            carToUpdated.ModelYear =car.ModelYear;
            carToUpdated.DailyPrice =car.DailyPrice;
            carToUpdated.Description =car.Description;
        }
    }
}
