namespace SWD_Mandatory_Decorator
{
    public class TreeTopper : TreeDecorator
    {
        public override string Decorate()
        {
            return base.Decorate() + "Here, have a pretty star ";
        }

        public TreeTopper(IChristmasTree tree) : base(tree)
        {
        }
    }
}
