namespace gonzo.Patterns.Prototype
{
    class Client
    {
        private ConcretePrototype _concretePrototype;

        public void Operation()
        {
            var concretePrototype = _concretePrototype.Clone();
        }
    }
}
