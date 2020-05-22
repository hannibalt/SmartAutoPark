using System.Collections.Generic;

namespace TicketMach.VModels
{
    public class VehicleTypes
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
