using System.Collections.Generic;

namespace ControlSRC.VModels
{
    public class CarParkscs
    {
        public int ParkId { get; set; }
        public string ParkName { get; set; }
        public int? ParkCapacity { get; set; }
        public bool? ParkActive { get; set; }

        public virtual ICollection<Moderators> Moderators { get; set; }
    }
}
