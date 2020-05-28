using _AutoCarPark.Entities;
using System;
using System.Collections.Generic;

namespace _AutoParkData.Models
{
    public partial class PaymentType : IEntity
    {
        public int PaymType { get; set; }
        public decimal? PaymtQuantity { get; set; }
        public int? PaymtValidity { get; set; }
    }
}
