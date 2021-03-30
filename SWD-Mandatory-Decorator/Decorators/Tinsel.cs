using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_Mandatory_Decorator.Decorators
{
    public class Tinsel: TreeDecorator
    {
        public override string Decorate()
        {
            return base.Decorate() + "The tree blooms like the Lotus Flower with this Tinsel I just added! \n";
        }

        public Tinsel(ChristmasTreeImplementation tree) : base(tree)
        {
        }
    }
}
