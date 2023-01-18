using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

CarManager carManager = new CarManager(new InMemoryCarDal());
foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.ModelYear);
}