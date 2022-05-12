using Business.Concrete;
using DataAccess.Concrete;
using System;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager manager = new CarManager(new InMemoryCarDal());
            foreach (var car in manager.GetAll())
            {
                Console.WriteLine(car.Id+" "+car.BrandId+" "+car.ColorId+" "+car.ModelYear+" "+car.DailyPrice+" "+car.Description);
            }
            Console.WriteLine("GetById Operasyonu id = 2 ***************************************");
            var result = manager.GetById(2);
            Console.WriteLine(result.Id + " " + result.BrandId + " " + result.ColorId + " " + result.ModelYear + " " + result.DailyPrice + " " + result.Description);
            manager.Add(new Car { Id = 4,BrandId=2,ColorId=3,DailyPrice=400,Description="Mavi mavi",ModelYear=2013 });
            Console.WriteLine("Add Operasyonu sonrası id 4  ***************************************");
            foreach (var car in manager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }
            Console.WriteLine("Delete Operasyonu**********************************");
            manager.Delete(new Car {Id=4});
            foreach (var car in manager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }

            Console.WriteLine("Update Operasyonu Sonrası**********************************");
            manager.Update(new Car {Id=2,BrandId=10,ColorId=10,DailyPrice=1000,Description="Güncellendi",ModelYear=2022});
            foreach (var car in manager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }
        }
    }
}
