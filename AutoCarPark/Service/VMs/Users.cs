using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.VMs
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
