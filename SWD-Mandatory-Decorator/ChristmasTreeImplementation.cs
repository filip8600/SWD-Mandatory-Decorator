namespace SWD_Mandatory_Decorator
{
    public class ChristmasTreeImplementation : IChristmasTree
    {
        public string Decorate()
        {
            return "I am a Christmas tree";
        }
    }

    public class ChristmasLights : TreeDecorator
    {
        public string Decorate()
        {
            return base.Decorate() + "Here, have some candles ";
        }
    }
}