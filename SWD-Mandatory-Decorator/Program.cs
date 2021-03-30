using System;
using SWD_Mandatory_Decorator.Decorators;

namespace SWD_Mandatory_Decorator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the christmas wonderland!");
            IChristmasTree tree = new ChristmasLights(new ChristmasTreeImplementation());
            Console.WriteLine(tree.Decorate());
            
            IChristmasTree tree2 = new ChristmasLights(new TreeTopper( new ChristmasTreeImplementation()));
            Console.WriteLine(tree2.Decorate());
            

            IChristmasTree tree3 = new ChristmasLights(new TreeTopper( new FlagGarland(new ChristmasTreeImplementation())));
            Console.WriteLine(tree3.Decorate());

            IChristmasTree tree4 = new ChristmasLights(new TreeTopper(new FlagGarland(new Tinsel(new ChristmasTreeImplementation()))));
            Console.WriteLine(tree4.Decorate());

        }
    }
}
