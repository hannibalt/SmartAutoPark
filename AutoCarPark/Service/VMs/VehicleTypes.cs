using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.VMs
{
    public class VehicleTypes
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
