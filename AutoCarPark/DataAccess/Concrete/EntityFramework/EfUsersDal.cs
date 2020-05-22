using _AutoCarPark.DataAccess.EntityFramework;
using _AutoParkData.Models;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUsersDal : EfRepositoryBase<Users, AutoParkContext>, IUsersDal
    {
    }
}
