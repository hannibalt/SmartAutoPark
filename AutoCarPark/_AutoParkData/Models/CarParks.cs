using _AutoCarPark.Entities;
using System;
using System.Collections.Generic;

namespace _AutoParkData.Models
{
    public partial class CarParks:IEntity
    {
        public CarParks()
        {
            Moderators = new HashSet<Moderators>();
        }

        public int ParkId { get; set; }
        public string ParkName { get; set; }
        public int? ParkCapacity { get; set; }
        public bool? ParkActive { get; set; }

        public virtual ICollection<Moderators> Moderators { get; set; }
    }
}
