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
                new Car{CarID=1,BrandID=1,ColorID=1,ModelYear=2012,DailyPrice=150000,Description="Hyundai"},

                new Car{CarID=2,BrandID=2,ColorID=1,ModelYear=2015,DailyPrice=180000,Description="Ford"},

                new Car{CarID=3,BrandID=1,ColorID=2,ModelYear=2020,DailyPrice=450000,Description="Seat"}


            };
        }


        public void Add(Car car)
        {
          _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarID == car.CarID);
            _cars.Remove(carToDelete);
        }


        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carID)
        {
            return _cars.Where(c => c.CarID == carID).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.CarID== car.CarID);
            carToUpdate.CarID= car.CarID;
            carToUpdate.BrandID= car.BrandID;
            carToUpdate.ColorID= car.ColorID;
            carToUpdate.ModelYear= car.ModelYear;
        }
    }


}
