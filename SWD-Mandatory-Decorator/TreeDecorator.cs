namespace SWD_Mandatory_Decorator
{
    public class TreeDecorator :IChristmasTree
    {
        private ChristmasTreeImplementation _tree;

        public TreeDecorator(ChristmasTreeImplementation tree)
        {
            _tree = tree;
        }

        public virtual string Decorate()
        {
            return _tree.Decorate();
        }
    }
}