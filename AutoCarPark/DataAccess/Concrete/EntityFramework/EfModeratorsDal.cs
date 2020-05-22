using _AutoCarPark.DataAccess.EntityFramework;
using _AutoParkData.Models;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfModeratorsDal : EfRepositoryBase<Moderators, AutoParkContext>, IModeratorsDal
    {
    }
}
