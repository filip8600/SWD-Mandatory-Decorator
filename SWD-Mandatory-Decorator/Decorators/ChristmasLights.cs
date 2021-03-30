namespace SWD_Mandatory_Decorator
{
    public class ChristmasLights : TreeDecorator
    {
        public override string Decorate()
        {
            return base.Decorate() + "Here, have some candles ";
        }

        public ChristmasLights(IChristmasTree tree) : base(tree)
        {
        }
    }
}