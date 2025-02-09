﻿using AbstractFactory.MoveDefine;
using AbstractFactory.WeaponDefine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }
}
