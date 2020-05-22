using System.Collections.Generic;

namespace TicketMach.VModels
{
    public class Users
    {
        public int UseId { get; set; }
        public string UseName { get; set; }
        public string UseSurname { get; set; }
        public string UseCarPlate { get; set; }
        public int? TypId { get; set; }
        public bool? UseActive { get; set; }

        public virtual VehicleTypes Typ { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
