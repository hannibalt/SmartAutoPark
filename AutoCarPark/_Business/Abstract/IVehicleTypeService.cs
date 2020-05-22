using _AutoParkData.Models;
using System.Collections.Generic;

namespace _Business.Abstract
{
    public interface IVehicleTypeService
    {
        List<VehicleTypes> GetAll();
        List<VehicleTypes> GetById(int vehicleid);

        VehicleTypes GetVehicleTypesById(int id);
        void Add(VehicleTypes vehicle);
        void Update(VehicleTypes vehicle);
        void Delete(VehicleTypes vehicle);
    }
}
