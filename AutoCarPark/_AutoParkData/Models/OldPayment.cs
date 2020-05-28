using _AutoCarPark.Entities;
using System;
using System.Collections.Generic;

namespace _AutoParkData.Models
{
    public partial class OldPayment :IEntity
    {
        public int LogId { get; set; }
        public int? PaymId { get; set; }
        public decimal? PaymCost { get; set; }
        public int? LeftDay { get; set; }
        public int? ParkId { get; set; }
        public string PaymUserPlate { get; set; }
        public DateTime? EventDate { get; set; }
    }
}
