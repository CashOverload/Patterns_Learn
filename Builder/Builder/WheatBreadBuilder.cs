using Builder.Ingradients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    internal class WheatBreadBuilder : BreadBuilder
    {
        public override void SetAdditives()
        {
            this.Bread.Additives = new Additives() {Name = "Bread combine tool"};
        }

        public override void SetFlour()
        {
            this.Bread.Flour = new Flour() { Sort = "Wheat flour 1 class"};
        }

        public override void SetSalt()
        {
            this.Bread.Salt = new Salt();
        }
    }
}
