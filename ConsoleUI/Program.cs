using Business.Concrete;
using DataAccess.Concrete;
using System;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { Name = "Audi" });

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { Name = "Siyah" });

            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car {Name="A8",BrandId=1,ColorId=1,DailyPrice=500,ModelYear=2018,Description="Sunrooflu full + full paket" });


            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + " " + car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
            }

        }

    }
}
