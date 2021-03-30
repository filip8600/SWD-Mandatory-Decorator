namespace SWD_Mandatory_Decorator
{
    public class TreeTopper : TreeDecorator
    {
        public override string Decorate()
        {
            return base.Decorate() + decorateWithTreeTopper();
        }

        public TreeTopper(IChristmasTree tree) : base(tree)
        {
        }

        private string decorateWithTreeTopper()
        {
            return "Here, have a pretty star. ";
        }
    }
}
