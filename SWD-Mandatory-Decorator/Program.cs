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
            Console.WriteLine(tree);
            
            IChristmasTree tree2 = new ChristmasLights(new TreeTopper( new ChristmasTreeImplementation()));
            Console.WriteLine(tree2);
            

            IChristmasTree tree3 = new ChristmasLights(new TreeTopper( new FlagGarland(new ChristmasTreeImplementation())));
            Console.WriteLine(tree2.Decorate() ); 

        }
    }
}
