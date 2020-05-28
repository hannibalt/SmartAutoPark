using _AutoCarPark.Entities;
using System;
using System.Collections.Generic;

namespace _AutoParkData.Models
{
    public partial class CarParks : IEntity
    {
        public CarParks()
        {
            Logs = new HashSet<Logs>();
            Moderators = new HashSet<Moderators>();
            Payments = new HashSet<Payments>();
        }

        public int ParkId { get; set; }
        public string ParkName { get; set; }
        public int? ParkCapacity { get; set; }
        public bool? ParkActive { get; set; }

        public virtual ICollection<Logs> Logs { get; set; }
        public virtual ICollection<Moderators> Moderators { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
