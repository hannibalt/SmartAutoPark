using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSRC.VModels
{
   public class Moderators
    {
        public int ModId { get; set; }
        public string ModUsername { get; set; }
        public string ModEmail { get; set; }
        public string ModPassword { get; set; }
        public int? ByParkId { get; set; }
        public virtual CarParkscs ByPark { get; set; }

    }
}
