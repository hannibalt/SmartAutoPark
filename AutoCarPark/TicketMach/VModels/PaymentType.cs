using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMach.VModels
{
    public class PaymentType
    {
        public int PaymType { get; set; }
        public decimal? PaymtQuantity { get; set; }
        public int? PaymtValidity { get; set; }
    }
}
