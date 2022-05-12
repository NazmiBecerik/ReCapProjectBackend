using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2012,DailyPrice=500,Description="En iyi araba bu araba"},
            new Car{Id=2,BrandId=2,ColorId=4,ModelYear=2010,DailyPrice=350,Description="En güzel araba bu araba"},
            new Car{Id=3,BrandId=1,ColorId=2,ModelYear=2017,DailyPrice=800,Description="En hızlı araba bu araba"},
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var deletedToCar = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(deletedToCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            var result = _cars.SingleOrDefault(c => c.Id == id);
            return result;
        }

        public void Update(Car car)
        {
            Car updatedToCar = _cars.SingleOrDefault(c=>c.Id==car.Id);
            updatedToCar.ColorId = car.ColorId;
            updatedToCar.BrandId = car.BrandId;
            updatedToCar.DailyPrice = car.DailyPrice;
            updatedToCar.Description = car.Description;
            updatedToCar.ModelYear = car.ModelYear;
        }
    }
}
