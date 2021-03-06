namespace SWD_Mandatory_Decorator
{
    public class TreeDecorator :IChristmasTree
    {
        private readonly IChristmasTree _tree;

        public TreeDecorator(IChristmasTree tree)
        {
            _tree = tree;
        }

        public virtual string Decorate()
        {
            return _tree.Decorate();
        }
    }
}