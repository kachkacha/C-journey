﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Design_Patterns.Factory {
    internal class Truck : ITransport{
        public bool Deliver() => true;
    }
}
