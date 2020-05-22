using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMach.VModels
{
    public class CarParks
    {
        public int ParkId { get; set; }
        public string ParkName { get; set; }
        public int? ParkCapacity { get; set; }
        public bool? ParkActive { get; set; }

        public virtual ICollection<Moderators> Moderators { get; set; }
    }
}
