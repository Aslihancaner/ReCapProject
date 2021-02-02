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
            _cars = new List<Car>
            {
               new Car{Id=1,BrandId=2,ColorId=5,DailyPrice=450,ModelYear="2015",Description="Dizel Otomatik"},
               new Car{Id=2,BrandId=4,ColorId=5,DailyPrice=1200,ModelYear="2021",Description="Benzinli Manuel "},
               new Car{Id=3,BrandId=1,ColorId=6,DailyPrice=900,ModelYear="2020",Description="Dizel Manuel"},
               new Car{Id=4,BrandId=3,ColorId=1,DailyPrice=475,ModelYear="2017",Description="Dizel Manuel"},
               new Car{Id=5,BrandId=2,ColorId=7,DailyPrice=650,ModelYear="2019",Description="Benzinli Otomatik"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
