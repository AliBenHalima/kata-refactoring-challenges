﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Interfaces.Factory
{
    public interface IGildedRoseFactory
    {
        IItemStrategy CreateItemStartegy(string Name);
    }
}
