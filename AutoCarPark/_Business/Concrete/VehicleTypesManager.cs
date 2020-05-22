using _AutoParkData.Models;
using _Business.Abstract;
using DataAccess.Abstract;
using System.Collections.Generic;

namespace _Business.Concrete
{
    public class VehicleTypesManager : IVehicleTypeService
    {
        private IVehicleTypesDal _vehicleTypes;
        public VehicleTypesManager(IVehicleTypesDal vehicleTypes)
        {
            _vehicleTypes = vehicleTypes;
        }
        public void Add(VehicleTypes vehicle)
        {
            _vehicleTypes.Add(vehicle);
        }

        public void Delete(VehicleTypes vehicle)
        {
            _vehicleTypes.Delete(vehicle);
        }

        public List<VehicleTypes> GetAll()
        {
            return _vehicleTypes.GetList();
        }

        public List<VehicleTypes> GetById(int vehicleid)
        {
            return _vehicleTypes.GetList(l => l.TypeId == vehicleid);
        }

        public VehicleTypes GetVehicleTypesById(int id)
        {
            var vehicles = _vehicleTypes.Get(c => c.TypeId == id);
            return vehicles;
        }

        public void Update(VehicleTypes vehicle)
        {
            _vehicleTypes.Update(vehicle);
        }
    }
}
