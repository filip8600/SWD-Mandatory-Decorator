using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_Mandatory_Decorator.Decorators
{
    public class ChristmasHearts:TreeDecorator
    {
        public override string Decorate()
        {
            return base.Decorate() + decorateWithChristmasHearts();
        }

        private string decorateWithChristmasHearts()
        {
            return "Here is some loooove (christmas hearts). ";
        }

        public ChristmasHearts(IChristmasTree tree) : base(tree)
        {
        }
    }
}
