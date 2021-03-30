namespace SWD_Mandatory_Decorator
{
    public class ChristmasLights : TreeDecorator
    {
        public string Decorate()
        {
            return base.Decorate() + "Here, have some candles ";
        }
    }
}