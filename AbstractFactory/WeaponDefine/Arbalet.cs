using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.WeaponDefine
{
    internal class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Arbalet shoots");
        }
    }
}
