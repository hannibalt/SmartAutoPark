using _AutoCarPark.DataAccess.EntityFramework;
using _AutoParkData.Models;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfVehicleTypesDal : EfRepositoryBase<VehicleTypes, AutoParkContext>, IVehicleTypesDal
    {
    }
}
