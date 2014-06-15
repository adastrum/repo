namespace gonzo.Patterns.Builder
{
    abstract class Builder
    {
        private Product _product = new Product();

        public abstract void BuildPart();

        public Product Product
        {
            get { return _product; }
        }
    }

    class ConcreteBuilder : Builder
    {
        public override void BuildPart()
        {
        }
    }
}
