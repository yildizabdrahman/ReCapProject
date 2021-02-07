using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=100, Description="Kiralık Araba", ModelYear=2010},
                new Car{Id=2, BrandId=2, ColorId=2, DailyPrice=120, Description="Kiralık Araba", ModelYear=2015},
                new Car{Id=3, BrandId=3, ColorId=1, DailyPrice=150, Description="Kiralık Araba", ModelYear=2018},
                new Car{Id=4, BrandId=4, ColorId=2, DailyPrice=200, Description="Kiralık Araba", ModelYear=2020},
                new Car{Id=4, BrandId=5, ColorId=3, DailyPrice=250, Description="Kiralık Araba", ModelYear=2021},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteToCar = _cars.SingleOrDefault(c => c.Id==car.Id);
            _cars.Remove(deleteToCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
           return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
