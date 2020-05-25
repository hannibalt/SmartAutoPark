using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSRC.VModels
{
    public class Logs
    {
        public int LogId { get; set; }
        public string SubPlate { get; set; }
        public int? VehicleType { get; set; }
        public int? ParkId { get; set; }
        public DateTime? CarEntryTime { get; set; }
        public DateTime? CarOutTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
