﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Design_Patterns.Factory {
    internal class ShipLogistics : Logistics{
        public override ITransport CreateTransport() => new Ship();
    }
}
