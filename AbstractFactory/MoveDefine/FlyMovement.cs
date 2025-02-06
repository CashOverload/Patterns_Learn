using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.MoveDefine
{
    internal class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Flying");
        }
    }
}
