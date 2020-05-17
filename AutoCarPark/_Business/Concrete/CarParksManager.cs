using _AutoParkData.Models;
using _Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Business.Concrete
{
    public class CarParksManager : ICarParksService
    {
        private ICarParksDal _carParksDal;
        public CarParksManager(ICarParksDal carParksDal)
        {
            _carParksDal = carParksDal;
        }

        public void Add(CarParks carparks)
        {
            _carParksDal.Add(carparks);
        }

        public void Delete(CarParks carparks)
        {
            _carParksDal.Delete(carparks);
        }

        public List<CarParks> GetAll()
        {
          return  _carParksDal.GetList();
        }

        public List<CarParks> GetById(int carParksId)
        {
            return _carParksDal.GetList(c => c.ParkId == carParksId);
        }

        public CarParks GetCarParks(int id)
        {
            var carpark=_carParksDal.Get(c => c.ParkId == id);
            return carpark;
        }

        public void Update(CarParks carparks)
        {
            _carParksDal.Update(carparks);
        }
    }
}
