using Business.Concrete;
using Business.Constants;
using Core.Utilities.Helpers.FileHelper;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
using static System.Net.Mime.MediaTypeNames;


CarManager carManager = new CarManager(new EfCarDal());
BrandManager brandManager = new BrandManager(new EfBrandDal());
ColorManager colorManager = new ColorManager(new EfColorDal());
UserManager userManager = new UserManager(new EfUserDal());
RentalManager rentalManager = new RentalManager(new EfRentalDal());
CarImageManager carImageManager = new CarImageManager(new EfCarImageDal(),new FileHelper());
var brand1 = new List<Brand>()
{
    new Brand {BrandId=1,Name="BMW"},
    new Brand {BrandId=2,Name="RENAULT"},
};

//foreach (var brand in brand1)
//{
//    brandManager.Add(brand);
//}

var color1 = new List<Entities.Concrete.Color>()
{
    new Color {ColorId=1,Name="Siyah"},
    new Color {ColorId=2,Name="Kırmızı"},
    new Color {ColorId=3,Name="Beyaz"},

};

//foreach (var brand in color1)
//{
//    colorManager.Add(brand);
//}

var car1 = new List<Car>() {
    new Car{CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 100000, ModelYear = 1999, Description = "iyi", CarName = "BMW 335ci"},
    new Car { CarId = 2, BrandId = 1, ColorId = 3, DailyPrice = 103000, ModelYear = 2000, Description = "kötü", CarName = "BMW 418i" },
    new Car { CarId = 3, BrandId = 2, ColorId = 3, DailyPrice = 145000, ModelYear = 2001, Description = "iyi", CarName = "RENAULT Fluence" },
    new Car { CarId = 4, BrandId = 2, ColorId = 3, DailyPrice = 146000, ModelYear = 2002, Description = "kötü", CarName = "RENAULT Clio" },
    new Car { CarId = 5, BrandId = 1, ColorId = 2, DailyPrice = 174000, ModelYear = 2003, Description = "iyi", CarName = "BMW M8" }
};

//foreach (var brand in car1)
//{
//    carManager.Add(brand);
//}

//var user1 = new List<User>()
//{
//    new User{UserId=1,FirstName="Tarık",LastName="Bayram",Email="abc@gmail.com",Password="123"},
//    new User{UserId=2,FirstName="Meryem",LastName="Bayram",Email="abc@gmail.com",Password="123"},
//    new User{UserId=3,FirstName="İbrahim",LastName="Bayram",Email="abc@gmail.com",Password="123"},
//    new User{UserId=4,FirstName="Rümeysa",LastName="Bayram",Email="abc@gmail.com",Password="123"},
//    new User{UserId=5,FirstName="İsmail",LastName="Bayram",Email="abc@gmail.com",Password="123"},

//};
//foreach (var brand in user1)
//{
//    userManager.Add(brand);
//}

var rental2 = new Rental()
{
    RentalId = 4,CarId =1, CustomerId=1, RentDate=DateTime.Now,ReturnDate=null
};

//rentalManager.Add(rental2);

var carImage = new CarImage()
{
    CarId = 2,
    CarImageId = 2,
    Date = DateTime.Now,
    ImagePath = "12.jpg"
};

//carImageManager.Delete(carImage);


string Upload()
{
    string filePath = "";
    FileStream source = File.Open(@"C:\Users\tkbay\OneDrive\Masaüstü\Projeler\.netCore_Calısmaları\ReCapProject\ReCapProject\DataAccess\Assets\img\1.png", FileMode.Open);
    var root = "wwwroot\\Uploads\\Images\\";
    if (source.Length > 0)
    {
        if (!Directory.Exists(root))
        {
            Directory.CreateDirectory(root);
        }
        var extension = Path.GetExtension(source.Name);
        var guid = Guid.NewGuid().ToString();
        filePath = guid + extension;
        using (FileStream fs = File.Create(root + filePath))
        {
            source.CopyTo(fs);
            Console.WriteLine(fs.Name);
            fs.Flush();
            return filePath;
        }
    }
    return filePath;
}
var result = Upload();
Console.WriteLine(result);

//FileStream fs = new FileStream(path+@"",FileMode.Open);
//Console.WriteLine(Path.GetExtension(fs.Name));
//Console.WriteLine(Guid.NewGuid().ToString());
//Console.WriteLine(Guid.NewGuid());

//byte[] img = new byte[fs.Length];
//fs.Read(img, 0, Convert.ToInt32(fs.Length));

