namespace gonzo.Patterns.Prototype
{
    interface IPrototype
    {
        IPrototype Clone();
    }

    class ConcretePrototype : IPrototype
    {
        public IPrototype Clone()
        {
            return new ConcretePrototype();
        }
    }
}
