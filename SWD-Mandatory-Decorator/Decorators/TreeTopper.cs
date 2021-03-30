namespace SWD_Mandatory_Decorator
{
    public class TreeTopper : TreeDecorator
    {
        public override string Decorate()
        {
            return base.Decorate() + DecorateWithTreeTopper();
        }

        public TreeTopper(IChristmasTree tree) : base(tree)
        {
        }

        private string DecorateWithTreeTopper()
        {
            return "Here, have a pretty star. ";
        }
    }
}
