using Builder.Ingradients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    internal class RyeBreadBuilder : BreadBuilder
    {
        public override void SetAdditives()
        {
            //not using for this bread
        }

        public override void SetFlour()
        {
            this.Bread.Flour = new Flour() { Sort = "Rye flour 1 class" };
        }

        public override void SetSalt()
        {
            this.Bread.Salt = new Salt();
        }
    }
}
