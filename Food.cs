﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Food
    {
        public abstract string TypeName { get; }
        public abstract int Health { get; init; }
    }
}
