using _AutoCarPark.Entities;
using System;
using System.Collections.Generic;

namespace _AutoParkData.Models
{
    public partial class Logs : IEntity
    {
        public int LogId { get; set; }
        public string SubPlate { get; set; }
        public int? VehicleType { get; set; }
        public int? ParkId { get; set; }
        public DateTime? CarEntryTime { get; set; }
        public DateTime? CarOutTime { get; set; }
        public bool? IsActive { get; set; }

        public virtual CarParks Park { get; set; }
        public virtual Users SubPlateNavigation { get; set; }
    }
}
