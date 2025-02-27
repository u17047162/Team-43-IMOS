﻿using System;
using System.Collections.Generic;

#nullable disable

namespace IMOSApi.Models
{
    public partial class VehicleCheckOut
    {
        public int CheckOutId { get; set; }
        public DateTime Date { get; set; }
        public int Odometer { get; set; }
        public int VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}
