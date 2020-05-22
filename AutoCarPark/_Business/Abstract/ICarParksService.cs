using _AutoParkData.Models;
using System.Collections.Generic;

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
