﻿using FactoryMethod.HouseFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.DeveloperFactory
{
    internal class WoodDeveloper : Developer
    {
        public WoodDeveloper(string name) : base(name)
        {
        }

        public override House Create()
        {
            return new WoodHouse();
        }
    }
}
