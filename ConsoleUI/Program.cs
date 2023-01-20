using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

CarManager carManager = new CarManager(new EfCarDal());

Car car1 = new Car() { CarId=2,BrandId=1,ColorId=1,DailyPrice=100000,ModelYear=1999,Description="iyi", CarName="BMW"};
carManager.Delete(car1);

//foreach (var car in carManager.GetCarsByColorId(1))
//{
//    Console.WriteLine(car.ModelYear);
//}
