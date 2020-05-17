using _AutoParkData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Business.Abstract
{
   public interface ICarParksService
    {
        List<CarParks> GetAll();
        List<CarParks> GetById(int carParksId);
        
        CarParks GetCarParks(int id);
        void Add(CarParks carparks);
        void Update(CarParks carparks);
        void Delete(CarParks carparks);
    }
}
