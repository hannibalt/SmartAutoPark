using _AutoCarPark.Entities;
using System.Collections.Generic;

namespace _AutoParkData.Models
{
    public partial class VehicleTypes : IEntity
    {
        public VehicleTypes()
        {
            Users = new HashSet<Users>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
