using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

CarManager carManager = new CarManager(new EfCarDal());
BrandManager brandManager = new BrandManager(new EfBrandDal());
ColorManager colorManager = new ColorManager(new EfColorDal());

var brand1 = new List<Brand>()
{
    new Brand {BrandId=1,Name="BMW"},
    new Brand {BrandId=2,Name="RENAULT"},

};

var color1 = new List<Color>()
{
    new Color {ColorId=1,Name="Siyah"},
    new Color {ColorId=2,Name="Kırmızı"},
    new Color {ColorId=3,Name="Beyaz"},

};

var car1 = new List<Car>() {
    new Car{CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 100000, ModelYear = 1999, Description = "iyi", CarName = "BMW 335ci"},
    new Car { CarId = 2, BrandId = 1, ColorId = 3, DailyPrice = 103000, ModelYear = 2000, Description = "kötü", CarName = "BMW 418i" },
    new Car { CarId = 3, BrandId = 2, ColorId = 3, DailyPrice = 145000, ModelYear = 2001, Description = "iyi", CarName = "RENAULT Fluence" },
    new Car { CarId = 4, BrandId = 2, ColorId = 3, DailyPrice = 146000, ModelYear = 2002, Description = "kötü", CarName = "RENAULT Clio" },
    new Car { CarId = 5, BrandId = 1, ColorId = 2, DailyPrice = 174000, ModelYear = 2003, Description = "iyi", CarName = "BMW M8" }
};

var result = carManager.GetCarDetails();
foreach (var car in result.Data)
{
    Console.WriteLine("{0} / {1} / {2}", car.CarName, car.BrandName, car.ColorName);
}
