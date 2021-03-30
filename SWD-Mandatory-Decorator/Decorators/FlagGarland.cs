﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SWD_Mandatory_Decorator.Decorators
{
    public class FlagGarland: TreeDecorator
    {
        public override string Decorate()
        {
            return base.Decorate() + decorateWithFlagGarland();
        }

        private string decorateWithFlagGarland()
        {
            return "You might not be Danish, but here are some pretty flags. ";
        }

        public FlagGarland(IChristmasTree tree) : base(tree)
        {
        }
    }
}
