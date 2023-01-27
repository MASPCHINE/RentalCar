using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Runtime.ConstrainedExecution;

CarManager carManager = new CarManager(new EfCarDal());
BrandManager brandManager = new BrandManager(new EfBrandDal());
ColorManager colorManager = new ColorManager(new EfColorDal());
UserManager userManager = new UserManager(new EfUserDal());
RentalManager rentalManager = new RentalManager(new EfRentalDal());
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
var user1 = new List<User>()
{
    new User{UserId=1,FirstName="Tarık",LastName="Bayram",Email="abc@gmail.com",Password="123"},
    new User{UserId=2,FirstName="Meryem",LastName="Bayram",Email="abc@gmail.com",Password="123"},
    new User{UserId=3,FirstName="İbrahim",LastName="Bayram",Email="abc@gmail.com",Password="123"},
    new User{UserId=4,FirstName="Rümeysa",LastName="Bayram",Email="abc@gmail.com",Password="123"},
    new User{UserId=5,FirstName="İsmail",LastName="Bayram",Email="abc@gmail.com",Password="123"},

};

var rental2 = new Rental()
{
    RentalId = 4,CarId =1, CustomerId=1, RentDate=DateTime.Now,ReturnDate=null
};

