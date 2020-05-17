using _AutoCarPark.Entities;
using System;
using System.Collections.Generic;

namespace _AutoParkData.Models
{
    public partial class Users : IEntity
    {
        public Users()
        {
            Logs = new HashSet<Logs>();
            Payments = new HashSet<Payments>();
        }

        public int UseId { get; set; }
        public string UseName { get; set; }
        public string UseSurname { get; set; }
        public string UseCarPlate { get; set; }
        public int? TypId { get; set; }
        public bool? UseActive { get; set; }

        public virtual VehicleTypes Typ { get; set; }
        public virtual ICollection<Logs> Logs { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
